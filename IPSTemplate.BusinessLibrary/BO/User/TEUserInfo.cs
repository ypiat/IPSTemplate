using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;
using Newtonsoft.Json.Serialization;

namespace IPSTemplate.BusinessLibrary.BO.User
{
    [Serializable]
    public class TEUserInfo : CslaReadOnlyBase<TEUserInfo, TEUser>
    {
        #region Properties

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(p => p.FirstName);
        [Display(Name = "Ime")]
        public string FirstName
        {
            get => GetProperty(FirstNameProperty);
            set => LoadProperty(FirstNameProperty, value);
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(p => p.LastName);
        [Display(Name = "Priimek")]
        public string LastName
        {
            get => GetProperty(LastNameProperty);
            set => LoadProperty(LastNameProperty, value);
        }

        [Display(Name = "Uporabnik")]
        public string ShowFullName
        {
            get => String.Format($"{FirstName} {LastName}");
        }

        public static readonly PropertyInfo<DateTime?> DateOfBirthProperty = RegisterProperty<DateTime?>(p => p.DateOfBirth);
        [Display(Name = "Datum rojstva")]
        public DateTime? DateOfBirth
        {
            get => GetProperty(DateOfBirthProperty);
            set => LoadProperty(DateOfBirthProperty, value);
        }

        public string? ShowDateAs
        {
            get 
            {
                return DateOfBirth?.ToString("dd/MM/yyyy");
            }
                 
        }

        public static readonly PropertyInfo<string?> EmailProperty = RegisterProperty<string?>(p => p.Email);
        [Display(Name = "Email")]
        public string? Email
        {
            get => GetProperty(EmailProperty);
            set => LoadProperty(EmailProperty, value);
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
