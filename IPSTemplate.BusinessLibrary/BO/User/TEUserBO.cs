using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;
using Newtonsoft.Json.Serialization;

namespace IPSTemplate.BusinessLibrary.BO.User
{
    [Serializable]
    public class TEUserBO : CslaBusinessBase<TEUserBO, TEUser>
    {
        #region Properties

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(p => p.FirstName);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Ime")]
        public string FirstName
        {
            get => GetProperty(FirstNameProperty);
            set => SetProperty(FirstNameProperty, value);
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(p => p.LastName);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Priimek")]
        public string LastName
        {
            get => GetProperty(LastNameProperty);
            set => SetProperty(LastNameProperty, value);
        }

        public string ShowFullName
        {
            get => String.Format($"{FirstName} {LastName}");
        }

        public static readonly PropertyInfo<DateTime?> DateOfBirthProperty = RegisterProperty<DateTime?>(p => p.DateOfBirth);
        [Display(Name = "Datum rojstva")]
        public DateTime? DateOfBirth
        {
            get => GetProperty(DateOfBirthProperty);
            set => SetProperty(DateOfBirthProperty, value);
        }

        public static readonly PropertyInfo<string?> EmailProperty = RegisterProperty<string?>(p => p.Email);
        [RegularExpression(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$", ErrorMessage = "Neveljaven e-poštni vzorec (example@example.com")]
        [Display(Name = "Email")]
        public string? Email
        {
            get => GetProperty(EmailProperty);
            set => SetProperty(EmailProperty, value);
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
