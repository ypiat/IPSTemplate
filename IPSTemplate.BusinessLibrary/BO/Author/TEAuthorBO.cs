using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using Csla.Rules;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Author
{
    [Serializable]
    public class TEAuthorBO : CslaBusinessBase<TEAuthorBO, TEAuthor>
    {
        #region Properties

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(p => p.FirstName);
        [Required(ErrorMessage = "Polje Ime je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Ime")]
        public string FirstName
        {
            get => GetProperty(FirstNameProperty);
            set => SetProperty(FirstNameProperty, value);
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(p => p.LastName);
        [Required(ErrorMessage = "Polje Priimek je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Priimek")]
        public string LastName
        {
            get => GetProperty(LastNameProperty);
            set => SetProperty(LastNameProperty, value);
        }

        public static readonly PropertyInfo<int?> BirthYearProperty = RegisterProperty<int?>(p => p.BirthYear);
        [Display(Name = "Letnica rojstva")]
        public int? BirthYear
        {
            get => GetProperty(BirthYearProperty);
            set => SetProperty(BirthYearProperty, value);
        }

        public static readonly PropertyInfo<int?> DeathYearProperty = RegisterProperty<int?>(p => p.DeathYear);
        [Display(Name = "Letnica smrti")]
        public int? DeathYear
        {
            get => GetProperty(DeathYearProperty);
            set => SetProperty(DeathYearProperty, value);
        }

        public static readonly PropertyInfo<string> CountryProperty = RegisterProperty<string>(p => p.Country);
        [Display(Name = "Država")]
        public string Country
        {
            get => GetProperty(CountryProperty);
            set => SetProperty(CountryProperty, value);
        }

        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        protected override void AddBusinessRules()
        {
            BusinessRules.AddRule(new IsDeathYearInRightRange(DeathYearProperty));
            BusinessRules.AddRule(new IsBirthYearInRightRange(BirthYearProperty));
            base.AddBusinessRules();
        }

        private class IsDeathYearInRightRange : BusinessRule
        {
            public IsDeathYearInRightRange(Csla.Core.IPropertyInfo deathYearProperty) : base(deathYearProperty)
            {
                InputProperties.Add(PrimaryProperty);
            }

            protected override void Execute(IRuleContext context)
            {
                int? deathYear = null;
                if (!context.TryGetInputValue(PrimaryProperty, ref deathYear))
                {
                    return;
                }

                if ( deathYear > DateTime.Now.Year || deathYear < 1)
                {
                    context.AddErrorResult($"Leto mora biti v območju 1 - {DateTime.Now.Year.ToString()}");
                }
            }
        }

        private class IsBirthYearInRightRange : BusinessRule
        {
            public IsBirthYearInRightRange(Csla.Core.IPropertyInfo birthYearProperty) : base(birthYearProperty)
            {
                InputProperties.Add(PrimaryProperty);
            }

            protected override void Execute(IRuleContext context)
            {
                int? birthYear = null;
                if (!context.TryGetInputValue(PrimaryProperty, ref birthYear))
                {
                    return;
                }

                if (birthYear > DateTime.Now.AddYears(-5).Year || birthYear < 1)
                {
                    context.AddErrorResult($"Leto mora biti v območju 1 - {DateTime.Now.AddYears(-5).Year.ToString()}");
                }
            }
        }

        #endregion

        #region Client-side methods

        #endregion

        #region Server-side methods

        #endregion
    }
}
