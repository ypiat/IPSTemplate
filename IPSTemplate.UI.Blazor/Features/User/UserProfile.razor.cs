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
    public partial class UserProfile : EditView<TEUserBO, Entity>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject]
        UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [Inject]
        IDataPortalFactory DataPortalFactory { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == true)
            {
                var userId = userManager.GetUserId(user);

                await ViewModel.RefreshAsync(() => TEUserGetCommand.GetUserAsync(Guid.Parse(userId), DataPortalFactory));

                if (ViewModel.Model is null)
                {
                    Error = Localizer["Global_DataNotFound"];
                }
            }
        }

    }
}
