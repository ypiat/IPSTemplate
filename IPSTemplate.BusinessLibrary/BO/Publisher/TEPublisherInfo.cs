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

namespace IPSTemplate.BusinessLibrary.BO.Publisher
{
    [Serializable]
    public class TEPublisherInfo : CslaReadOnlyBase<TEPublisherInfo, TEPublisher>
    {
        #region Properties

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Display(Name = "Ime")]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => LoadProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string?> AddressProperty = RegisterProperty<string?>(p => p.Address);
        [Display(Name = "Naslov")]
        public string? Address
        {
            get => GetProperty(AddressProperty);
            set => LoadProperty(AddressProperty, value);
        }

        public static readonly PropertyInfo<string?> EmailProperty = RegisterProperty<string?>(p => p.Email);
        [Display(Name = "Email")]
        public string? Email
        {
            get => GetProperty(EmailProperty);
            set => LoadProperty(EmailProperty, value);
        }

        #endregion
    }
}
