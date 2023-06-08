using System.ComponentModel.DataAnnotations;
using Core.Library;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Serialization;

namespace IPSTemplate.BusinessLibrary.BO.Borrowings
{
    [Serializable]
    public class TEBorrowingsInfo : CslaReadOnlyBase<TEBorrowingsInfo, TEBorrowings>
    {
        #region Properties

        public static readonly PropertyInfo<Guid> BookCopyIDProperty = RegisterProperty<Guid>(p => p.BookCopyID);

        [Display(Name = "BookCopyId")]
        public Guid BookCopyID
        {
            get => GetProperty(BookCopyIDProperty);
            set => LoadProperty(BookCopyIDProperty, value);
        }

        public static readonly PropertyInfo<int> BookCopyBookCopyNumberProperty = RegisterProperty<int>(p => p.BookCopyBookCopyNumber);
        [Display(Name = "Številka kopije")]
        public int BookCopyBookCopyNumber
        {
            get => GetProperty(BookCopyBookCopyNumberProperty);
            set => LoadProperty(BookCopyBookCopyNumberProperty, value);
        }

        public static readonly PropertyInfo<string> BookCopyBookNameProperty = RegisterProperty<string>(p => p.BookCopyBookName);
        [Display(Name = "Naslov")]
        public string BookCopyBookName
        {
            get => GetProperty(BookCopyBookNameProperty);
            set => LoadProperty(BookCopyBookNameProperty, value);
        }

        public static readonly PropertyInfo<Guid> UserIDProperty = RegisterProperty<Guid>(p => p.UserID);
        [Display(Name = "UserId")]
        public Guid UserID
        {
            get => GetProperty(UserIDProperty);
            set => LoadProperty(UserIDProperty, value);
        }

        public static readonly PropertyInfo<string> UserNameProperty = RegisterProperty<string>(p => p.UserName);
        [Display(Name = "Ime userja")]
        public string UserName
        {
            get => GetProperty(UserNameProperty);
            set => LoadProperty(UserNameProperty, value);
        }

        public static readonly PropertyInfo<string> UserSurnameProperty = RegisterProperty<string>(p => p.UserSurname);
        [Display(Name = "Priimek userja")]
        public string UserSurname
        {
            get => GetProperty(UserSurnameProperty);
            set => LoadProperty(UserSurnameProperty, value);
        }

        [Display(Name = "Uporabnik")]
        [CustomFilter(Property = new[] { nameof(UserName), nameof(UserSurname) })]
        public string UserShowFullName
        {
            get => String.Format($"{UserName} {UserSurname}");
        }

        public static readonly PropertyInfo<DateTime> StartBorrowingProperty = RegisterProperty<DateTime>(p => p.StartBorrowing);
        [Display(Name = "Start izposoji")]
        public DateTime StartBorrowing
        {
            get => GetProperty(StartBorrowingProperty);
            set => LoadProperty(StartBorrowingProperty, value);
        }

        public static readonly PropertyInfo<DateTime> EndBorrowingProperty = RegisterProperty<DateTime>(p => p.EndBorrowing);
        [Display(Name = "Konec izposoji")]
        public DateTime EndBorrowing
        {
            get => GetProperty(EndBorrowingProperty);
            set => LoadProperty(EndBorrowingProperty, value);
        }

        public static readonly PropertyInfo<bool> IsReturnedProperty = RegisterProperty<bool>(p => p.IsReturned);
        public bool IsReturned
        {
            get => GetProperty(IsReturnedProperty);
            set => LoadProperty(IsReturnedProperty, value);
        }

        public string Status
        {
            get
            {
                if(IsReturned)
                {
                    return "Vrnjeno";
                }
                else
                {
                    return "V izposoji";
                }
            }
        }


        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        #endregion

        #region Client-side methods

        #endregion

        #region Server-side methods

        #endregion
    }
}
