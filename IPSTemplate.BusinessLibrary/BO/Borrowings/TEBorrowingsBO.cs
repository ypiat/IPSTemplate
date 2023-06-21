using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.Dal.Models;
using Newtonsoft.Json.Serialization;


namespace IPSTemplate.BusinessLibrary.BO.Borrowings
{
    [Serializable]
    public class TEBorrowingsBO : CslaBusinessBase<TEBorrowingsBO, TEBorrowings>
    {

        #region Properties

        public static readonly PropertyInfo<Guid> BookCopyIDProperty = RegisterProperty<Guid>(p => p.BookCopyID);
        [Required]
        [Display(Name = "BookCopyId")]
        public Guid BookCopyID
        {
            get => GetProperty(BookCopyIDProperty);
            set => SetProperty(BookCopyIDProperty, value);
        }

        public static readonly PropertyInfo<TEBookCopyBO> BookCopyProperty = RegisterProperty<TEBookCopyBO>(p => p.BookCopy);
        public TEBookCopyBO BookCopy
        {
            get => LazyGetProperty(BookCopyProperty, () => TEBookCopyBO.GetItem(BookCopyID, ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => SetProperty(BookCopyProperty, value);
        }


        public static readonly PropertyInfo<Guid> UserIDProperty = RegisterProperty<Guid>(p => p.UserID);
        [Required]
        [Display(Name = "UserId")]
        public Guid UserID
        {
            get => GetProperty(UserIDProperty);
            set => SetProperty(UserIDProperty, value);
        }

        public static readonly PropertyInfo<string> UserShowFullNameProperty = RegisterProperty<string>(p => p.UserShowFullName);
        [Display(Name = "Uporabnik")]
        public string UserShowFullName
        {
            get => GetProperty(UserShowFullNameProperty);
            set => SetProperty(UserShowFullNameProperty, value);
        }

        public static readonly PropertyInfo<DateTime> StartBorrowingProperty = RegisterProperty<DateTime>(p => p.StartBorrowing);
        [Display(Name = "Start izposoji")]
        public DateTime StartBorrowing
        {
            get => GetProperty(StartBorrowingProperty);
            set => SetProperty(StartBorrowingProperty, value);
        }

        public static readonly PropertyInfo<DateTime> EndBorrowingProperty = RegisterProperty<DateTime>(p => p.EndBorrowing);
        [Display(Name = "Konec izposoji")]
        public DateTime EndBorrowing
        {
            get => GetProperty(EndBorrowingProperty);
            set => SetProperty(EndBorrowingProperty, value);
        }

        public static readonly PropertyInfo<DateTime> ExtendEndBorrowingProperty = RegisterProperty<DateTime>(p => p.ExtendEndBorrowing);
        public DateTime ExtendEndBorrowing
        {
            get => EndBorrowing.AddDays(15);
        }

        public static readonly PropertyInfo<bool> IsReturnedProperty = RegisterProperty<bool>(p => p.IsReturned);
        public bool IsReturned
        {
            get => GetProperty(IsReturnedProperty);
            set => SetProperty(IsReturnedProperty, value);
        }


        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        #endregion

        #region Client-side methods
        protected override void Create()
        {
            StartBorrowing = DateTime.Now;
            EndBorrowing = DateTime.Now.AddDays(30);
            IsReturned = false;
            base.Create();
        }

        protected override Task CreateAsync(bool isAsync)
        {
            StartBorrowing = DateTime.Now;
            EndBorrowing = DateTime.Now.AddDays(30);
            IsReturned = false;
            return base.CreateAsync(isAsync);
        }

        public void OnBorrow()
        {
                IsReturned = false;
                BookCopy.IsAvailable = false;
                BookCopy = BookCopy.Save();
        }

        public void OnReturn()
        {
            EndBorrowing = DateTime.Now;
            IsReturned = true;
            BookCopy.IsAvailable = true;
            BookCopy = BookCopy.Save();
        }

        public void OnExtend()
        {
            IsReturned = false;
            EndBorrowing = EndBorrowing.AddDays(15);
            BookCopy.IsAvailable = false;
            BookCopy = BookCopy.Save();
        }

        #endregion

        #region Server-side methods

        #endregion
    }
}
