using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Author
{
    [Serializable]
    public class TEAuthorBO : CslaBusinessBase<TEAuthorBO, TEAuthor>
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

        public static readonly PropertyInfo<int?> BirthYearProperty = RegisterProperty<int?>(p => p.BirthYear);
        [Range(1, 2023)]
        [Display(Name = "Letnica rojstva")]
        public int? BirthYear
        {
            get => GetProperty(BirthYearProperty);
            set => SetProperty(BirthYearProperty, value);
        }

        public static readonly PropertyInfo<int?> DeathYearProperty = RegisterProperty<int?>(p => p.DeathYear);
        [Range(1, 2023)]
        [Display(Name = "Letnica smrti")]
        public int? DeathYear
        {
            get => GetProperty(DeathYearProperty);
            set => SetProperty(DeathYearProperty, value);
        }

        public static readonly PropertyInfo<string> CountryProperty = RegisterProperty<string>(p => p.Country);
        [Display(Name = "Country")]
        public string Country
        {
            get => GetProperty(CountryProperty);
            set => SetProperty(CountryProperty, value);
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
