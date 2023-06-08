using System.ComponentModel.DataAnnotations;
using System.Linq;
using Core.Library.Base;
using Csla;
using Csla.Rules;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyBO : CslaBusinessBase<TEBookCopyBO, TEBookCopy>
    {
        #region Properties

        public static readonly PropertyInfo<int> BookCopyNumberProperty = RegisterProperty<int>(p => p.BookCopyNumber);
        [Range(0, int.MaxValue)]
        [Display(Name = "Številka")]
        public int BookCopyNumber
        {
            get => GetProperty(BookCopyNumberProperty);
            set => SetProperty(BookCopyNumberProperty, value);
        }

        public static readonly PropertyInfo<Guid> BookIDProperty = RegisterProperty<Guid>(p => p.BookID);
        [Required]
        [Display(Name = "BookId")]
        public Guid BookID
        {
            get => GetProperty(BookIDProperty);
            set => SetProperty(BookIDProperty, value);
        }

        public static readonly PropertyInfo<string> BookNameProperty = RegisterProperty<string>(p => p.BookName);
        [Display(Name = "Naslov knjigi")]
        public string BookName
        {
            get => GetProperty(BookNameProperty);
            set => LoadProperty(BookNameProperty, value);
        }

        public static readonly PropertyInfo<Guid?> PublisherIDProperty = RegisterProperty<Guid?>(p => p.PublisherID);
        [Required(ErrorMessage = "Polje Založba je obvezno")]
        [Display(Name = "Založba")]
        public Guid? PublisherID
        {
            get => GetProperty(PublisherIDProperty);
            set => SetProperty(PublisherIDProperty, value);
        }

        public static readonly PropertyInfo<int?> PublishedYearProperty = RegisterProperty<int?>(p => p.PublishedYear);
        [Required(ErrorMessage = "Polje Leto izdaje je obvezno")]
        [Display(Name = "Leto izdaje")]
        public int? PublishedYear
        {
            get => GetProperty(PublishedYearProperty);
            set => SetProperty(PublishedYearProperty, value);
        }

        public static readonly PropertyInfo<bool> IsAvailableProperty = RegisterProperty<bool>(p => p.IsAvailable);
        [Display(Name = "IsAvailable")]
        public bool IsAvailable
        {
            get => GetProperty(IsAvailableProperty);
            set => SetProperty(IsAvailableProperty, value);
        }

        public static readonly PropertyInfo<TEBookCopyRL> BookBookCopiesProperty = RegisterProperty<TEBookCopyRL>(p => p.BookBookCopies);
        public TEBookCopyRL BookBookCopies
        {
            get => GetProperty(BookBookCopiesProperty);
            set => SetProperty(BookBookCopiesProperty, value);
        }


        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        protected override void AddBusinessRules()
        {
            BusinessRules.AddRule(new IsYearInRightRange(PublishedYearProperty));
            //BusinessRules.AddRule(new IsBookCopyNumberUnique(BookCopyNumberProperty));
            base.AddBusinessRules();
        }

        private class IsYearInRightRange : BusinessRule
        {
            public IsYearInRightRange(Csla.Core.IPropertyInfo PublishedYearProperty) : base(PublishedYearProperty)
            {
                InputProperties.Add(PrimaryProperty);
            }

            protected override void Execute(IRuleContext context)
            {
                int? PublishedYear = null;
                if (!context.TryGetInputValue(PrimaryProperty, ref PublishedYear))
                {
                    return;
                }

                if (PublishedYear > DateTime.Now.Year || PublishedYear < 1)
                {
                    context.AddErrorResult($"Leto mora biti v območju 1 - {DateTime.Now.Year.ToString()}");
                }
            }
        }

        //private class IsBookCopyNumberUnique : BusinessRule
        //{
        //    public IsBookCopyNumberUnique(Csla.Core.IPropertyInfo BookCopyNumberProperty) : base(BookCopyNumberProperty)
        //    {
        //        InputProperties.Add(PrimaryProperty);
        //    }

        //    protected override void Execute(IRuleContext context)
        //    {
        //        int BookCopyNumber = 0;

        //        if (!context.TryGetInputValue(PrimaryProperty, ref BookCopyNumber))
        //        {
        //            return;
        //        }



        //        if (BookBookCopies.Select(p => p.BookCopyNumber).ToList().Contains(BookCopyNumber))
        //        {
        //            context.AddErrorResult($"Ta številka kopije že obstaja");
        //        } 
        //        else if (BookCopyNumber == 0)
        //        {
        //            context.AddErrorResult($"0 ne more biti številka kopije knjige");
        //        }
        //    }
        //}



        #endregion

        #region Client-side methods

        protected override void Create()
        {
            IsAvailable = true;
            base.Create();
        }

        protected override Task CreateAsync(bool isAsync)
        {
            IsAvailable = true;
            return base.CreateAsync(isAsync);
        }

        public void SetBook(TEBookInfo book, IDataPortalFactory factory)
        {
            this.BookID = book.Id;
            var allCopies = TEBookCopyRL.GetByBookId(this.BookID, factory);
            this.BookCopyNumber = allCopies.Any() ? (allCopies.Select(p => p.BookCopyNumber).Max() + 1) : book.BookIndex + 1;
        }

        #endregion


        #region Server-side methods

        #endregion
    }
}
