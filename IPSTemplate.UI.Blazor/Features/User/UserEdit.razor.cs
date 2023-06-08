using Core.DAL.Infrastructure;
using Csla.Blazor;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.BusinessLibrary.BO.Identity.UserRole;
using IPSTemplate.Dal.Models.Identity;
using IPSTemplate.UI.Blazor.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;



namespace IPSTemplate.UI.Blazor.Features.User
{
    public partial class UserEdit : EditView<TEUserBO, Entity>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }


    }
}
