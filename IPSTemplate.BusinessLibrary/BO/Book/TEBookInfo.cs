using System.ComponentModel.DataAnnotations;
using Core.Library;
using Core.Library.Base;
using Csla;
using Csla.DataPortalClient;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.StandardCollections;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Book
{
    [Serializable]
    public class TEBookInfo : CslaReadOnlyBase<TEBookInfo, TEBook>
    {
        #region Properties

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Display(Name = "Naslov")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => LoadProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string> GenreNameProperty = RegisterProperty<string>(p => p.GenreName);
        [Display(Name = "Ime žanra")]
        public string GenreName
        {
            get => GetProperty(GenreNameProperty);
            set => LoadProperty(GenreNameProperty, value);
        }

        public static readonly PropertyInfo<string?> LanguageProperty = RegisterProperty<string?>(p => p.Language);
        [Display(Name = "Jezik")]
        public string? Language
        {
            get => GetProperty(LanguageProperty);
            set => LoadProperty(LanguageProperty, value);
        }

        [CustomFilter(Property = new[] { nameof(Language) })]
        public string UserFriendlyLanguageName
        {
            get => TELanguages.GetUserFriendlyName(Language);
        }

        public static readonly PropertyInfo<int?> PageAmountProperty = RegisterProperty<int?>(p => p.PageAmount);
        [Display(Name = "Število strani")]
        public int? PageAmount
        {
            get => GetProperty(PageAmountProperty);
            set => LoadProperty(PageAmountProperty, value);
        }
 


        public static readonly PropertyInfo<TEBookAuthorEL> BookAuthorsProperty = RegisterProperty<TEBookAuthorEL>(p => p.BookAuthors, RelationshipTypes.LazyLoad);
        public TEBookAuthorEL BookAuthors
        {
            get => LazyGetProperty(BookAuthorsProperty, () => GetAuthors(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(BookAuthorsProperty, value);
        }

        protected TEBookAuthorEL GetAuthors(IDataPortalFactory factory)
        {
            return TEBookAuthorEL.GetByBookId(Id, factory);
        }

        public static readonly PropertyInfo<TEAuthorRL> AuthorsProperty = RegisterProperty<TEAuthorRL>(p => p.Authors, RelationshipTypes.LazyLoad);
        public TEAuthorRL Authors
        {
            get => LazyGetProperty(AuthorsProperty, () => TEAuthorRL.GetListByIds(BookAuthors.Select(ba => ba.AuthorID), ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(AuthorsProperty, value);
        }

        [Display(Name = "Avtor/ji")]
        public string AuthorNames => String.Join(", ", Authors.Select(a => a.ShowAs));

        

        public static readonly PropertyInfo<TEBookCopyRL> BookCopiesProperty = RegisterProperty<TEBookCopyRL>(p => p.BookCopies, RelationshipTypes.LazyLoad);
        public TEBookCopyRL BookCopies
        {
            get => LazyGetProperty(BookCopiesProperty, () => GetBookCopies(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(BookCopiesProperty, value);
        }

        protected TEBookCopyRL GetBookCopies(IDataPortalFactory factory)
        {
            return TEBookCopyRL.GetByBookId(Id, factory);
        }

        public static readonly PropertyInfo<int> BookIndexProperty = RegisterProperty<int>(p => p.BookIndex);
        [Range(100, 999900)]
        [Display(Name = "Index knjigi")]
        public int BookIndex
        {
            get => GetProperty(BookIndexProperty);
            set => LoadProperty(BookIndexProperty, value);
        }



        //public static readonly PropertyInfo<TEBookRL> BooksProperty = RegisterProperty<TEBookRL>(p => p.Books, RelationshipTypes.LazyLoad);
        //public TEBookRL Books
        //{
        //    get => LazyGetProperty(BooksProperty, () => GetBooks(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
        //    set => LoadProperty(BooksProperty, value);
        //}

        //protected TEBookRL GetBooks(IDataPortalFactory factory)
        //{
        //    return TEBookRL.GetList(factory);
        //}



        //public int NewBookIndex
        //{
        //    get => Books.Any() ? (Books.Select(p => p.BookIndex).ToList().Max() + 100) : 100;
        //}

        //public int NewBookCopyNumber
        //{
        //    get => BookCopies.Any() ? (BookCopies.Select(p => p.BookCopyNumber).ToList().Max() + 1) : BookIndex + 1;
        //}

       

        #endregion


    }
}
