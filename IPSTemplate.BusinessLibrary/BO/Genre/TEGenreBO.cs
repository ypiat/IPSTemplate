using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Genre
{
    [Serializable]
    public class TEGenreBO : CslaBusinessBase<TEGenreBO, TEGenre>
    {
        #region Properties

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Required(ErrorMessage = "Polje Zanr je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Žanr")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => SetProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string> ColorProperty = RegisterProperty<string>(p => p.Color);
        [Required(ErrorMessage = "Polje Barva je obvezno")]
        [Display(Name = "Barva")]
        public string Color
        {
            get => GetProperty(ColorProperty);
            set => SetProperty(ColorProperty, value);
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
