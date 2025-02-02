﻿using Core.Library;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.StandardCollections;
using IPSTemplate.Dal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPSTemplate.BusinessLibrary.BO.Author
{
    [Serializable]
    public class TEAuthorInfo : CslaReadOnlyBase<TEAuthorInfo, TEAuthor>
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

        public static readonly PropertyInfo<int?> BirthYearProperty = RegisterProperty<int?>(p => p.BirthYear);
        [Display(Name = "Letnica rojstva")]
        public int? BirthYear
        {
            get => GetProperty(BirthYearProperty);
            set => LoadProperty(BirthYearProperty, value);
        }

        public static readonly PropertyInfo<int?> DeathYearProperty = RegisterProperty<int?>(p => p.DeathYear);
        [Display(Name = "Letnica smrti")]
        public int? DeathYear
        {
            get => GetProperty(DeathYearProperty);
            set => LoadProperty(DeathYearProperty, value);
        }

        public static readonly PropertyInfo<string> LifeYearsProperty = RegisterProperty<string>(p => p.LifeYears);
        [Display(Name = "Leta življenja")]
        [CustomFilter(Property = new[] { nameof(BirthYear) })]
        public string LifeYears 
        { 
             get {
                if (BirthYear is null && DeathYear is null)
                {
                    return String.Format("/");
                }
                else if (BirthYear is null)
                {
                return String.Format($"/ - {DeathYear}");
                }
                else if (DeathYear is null)
                {
                    return String.Format($"{BirthYear} - /");
                }
                else
                {
                    return String.Format($"{BirthYear} - {DeathYear}");
                }
             } 
        }

    public static readonly PropertyInfo<string> CountryProperty = RegisterProperty<string>(p => p.Country);
        [Display(Name = "Country")]
        public string Country
        {
            get => GetProperty(CountryProperty);
            set => LoadProperty(CountryProperty, value);
        }

        [CustomFilter(Property = new[] { nameof(Country) })]
        public string UserFriendlyCountryName
        {
            get { 
                if (Country is null || Country == "")
                {
                    return String.Format("/");
                }
                else
                {
                    return TECountries.GetUserFriendlyName(Country);
                }
            }       
        }



        public string ShowAs
        {
            get => FirstName + " " + LastName;
        }


        #endregion
    }
}
