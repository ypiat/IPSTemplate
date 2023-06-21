using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPSTemplate.BusinessLibrary.BO.Genre
{
    [Serializable]
    public class TEGenreInfo : CslaReadOnlyBase<TEGenreInfo, TEGenre>
    {
        #region Properties
        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Display(Name = "Žanr")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => LoadProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string> ColorProperty = RegisterProperty<string>(p => p.Color);
        [Display(Name = "Barva")]
        public string Color
        {
            get => GetProperty(ColorProperty);
            set => LoadProperty(ColorProperty, value);
        }
        #endregion
    }
}
