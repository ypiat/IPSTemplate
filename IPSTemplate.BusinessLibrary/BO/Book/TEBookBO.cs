using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using Csla.Rules;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Book
{
    [Serializable]
    public class TEBookBO : CslaBusinessBase<TEBookBO, TEBook>
    {
        #region Properties

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Required(ErrorMessage = "Polje Naslov je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Naslov")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => SetProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<Guid?> GenreIDProperty = RegisterProperty<Guid?>(p => p.GenreID);
        [Required(ErrorMessage = "Polje Žanr je obvezno")]
        [Display(Name = "Žanr")]
        public Guid? GenreID
        {
            get => GetProperty(GenreIDProperty);
            set => SetProperty(GenreIDProperty, value);
        }

        public static readonly PropertyInfo<string?> LanguageProperty = RegisterProperty<string?>(p => p.Language);
        [Display(Name = "Jezik")]
        public string? Language
        {
            get => GetProperty(LanguageProperty);
            set => SetProperty(LanguageProperty, value);
        }

        public static readonly PropertyInfo<int?> PageAmountProperty = RegisterProperty<int?>(p => p.PageAmount);
        [Range(1, 9999)]
        [Display(Name = "Število strani")]
        public int? PageAmount
        {
            get => GetProperty(PageAmountProperty);
            set => SetProperty(PageAmountProperty, value);
        }

        public static readonly PropertyInfo<string> DescriptionProperty = RegisterProperty<string>(p => p.Description);   
        [Display(Name = "Opis")]
        public string Description
        {
            get => GetProperty(DescriptionProperty);
            set => SetProperty(DescriptionProperty, value);
        }

        public static readonly PropertyInfo<TEBookAuthorEL> AuthorsProperty = RegisterProperty<TEBookAuthorEL>(p => p.Authors, RelationshipTypes.LazyLoad);
        public TEBookAuthorEL Authors
        {
            get => LazyGetProperty(AuthorsProperty, () => GetAuthors(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => SetProperty(AuthorsProperty, value);
        }

        protected TEBookAuthorEL GetAuthors(IDataPortalFactory factory)
        {
            return TEBookAuthorEL.GetByBookId(Id, factory);
        }

        public static readonly PropertyInfo<List<Guid>> AuthorIdsProperty = RegisterProperty<List<Guid>>(p => p.AuthorIds);
        [Display(Name = "Avtorji")]
        public List<Guid> AuthorIds
        {
            get { return Authors.Any() ? Authors.Select(p => p.AuthorID).ToList() : new List<Guid>(); }
            set
            {
                foreach (var authorId in value.Where(p => !Authors.Select(o => o.AuthorID).ToList().Contains(p)).ToList())
                {
                    var author = ApplicationContext.GetRequiredService<IDataPortalFactory>().GetPortal<TEBookAuthorBO>().Create();
                    author.BookID = Id;
                    author.AuthorID = authorId;
                    Authors.Add(author);
                    MarkDirty();
                    PropertyHasChanged(AuthorsProperty);
                }
                foreach (var item in Authors.Where(p => !value.Contains(p.AuthorID)).ToList()) { 
                    Authors.Remove(item);
                    MarkDirty();
                    PropertyHasChanged(AuthorsProperty);
                }
            }
        }

        public static readonly PropertyInfo<int> BookIndexProperty = RegisterProperty<int>(p => p.BookIndex);
        [Required(ErrorMessage = "Polje Index knjigi je obvezno (je unikalna številka knjigi)")]
        [Range(100, 999900)]
        [Display(Name = "Index knjigi")]
        public int BookIndex
        {
            get => GetProperty(BookIndexProperty);
            set => SetProperty(BookIndexProperty, value);
        }

        public static readonly PropertyInfo<int> GenerateBookIndexProperty = RegisterProperty<int>(p => p.GenerateBookIndex);
        public int GenerateBookIndex
        {
            get => Books.Any() ? (Books.Select(p => p.BookIndex).Max() + 100) : 100;
        }

        public static readonly PropertyInfo<TEBookRL> BooksProperty = RegisterProperty<TEBookRL>(p => p.Books, RelationshipTypes.LazyLoad);
        public TEBookRL Books
        {
            get => LazyGetProperty(BooksProperty, () => GetBooks(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(BooksProperty, value);
        }

        protected TEBookRL GetBooks(IDataPortalFactory factory)
        {
            return TEBookRL.GetList(factory);
        }

        


        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        protected override void AddBusinessRules()
        {
            BusinessRules.AddRule(new HasAtLeastOneAuthorRule(AuthorIdsProperty));
            BusinessRules.AddRule(new IsIndexUniqueRule(BookIndexProperty));
            base.AddBusinessRules();
        }

        private class HasAtLeastOneAuthorRule : BusinessRule
        {
            public HasAtLeastOneAuthorRule(Csla.Core.IPropertyInfo authorIdsProperty) : base(authorIdsProperty)
            {
                InputProperties.Add(PrimaryProperty);
                InputProperties.Add(AuthorsProperty);
            }

            protected override void Execute(IRuleContext context)
            {
                TEBookAuthorEL? authors = null;
                if (!context.TryGetInputValue(AuthorsProperty, ref authors))
                {
                    return;
                }

                if (authors is null || authors.Count < 1)
                {
                    context.AddErrorResult("At least one author is required.");
                }
            }
        }

        private class IsIndexUniqueRule : BusinessRule
        {
            public IsIndexUniqueRule(Csla.Core.IPropertyInfo bookIndexProperty) : base(bookIndexProperty)
            {
                InputProperties.Add(PrimaryProperty);
                InputProperties.Add(BooksProperty);
            }

            protected override void Execute(IRuleContext context)
           {
                TEBookRL? books = null;
                int bookIndex = 0;
                if (!context.TryGetInputValue(BooksProperty, ref books))
                {
                    return;
                }

                if (!context.TryGetInputValue(BookIndexProperty, ref bookIndex))
                {
                    return;
                }

                if (books.Select(p => p.BookIndex).ToList().Contains(bookIndex))
                {
                    context.AddErrorResult("Ta index že obstaja! Izberite drug.");
                }
            }
        }

        #endregion

        #region Client-side methods
        //protected override void Create()
        //{
        //    BookIndex = GenerateBookIndex;
        //    base.Create();
        //}

        //protected override Task CreateAsync(bool isAsync)
        //{
        //    BookIndex = GenerateBookIndex;
        //    return base.CreateAsync(isAsync);
        //}
        #endregion

        #region Server-side methods

        #endregion
    }
}
