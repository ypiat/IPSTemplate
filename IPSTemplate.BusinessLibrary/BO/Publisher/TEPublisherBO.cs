using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Publisher
{
    [Serializable]
    public class TEPublisherBO : CslaBusinessBase<TEPublisherBO, TEPublisher>
    {
        #region Properties

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Ime")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => SetProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string> AddressProperty = RegisterProperty<string>(p => p.Address);
        [Required]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Naslov")]
        public string Address
        {
            get => GetProperty(AddressProperty);
            set => SetProperty(AddressProperty, value);
        }

        public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(p => p.Email);
        [Display(Name = "Email")]
        public string Email
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
