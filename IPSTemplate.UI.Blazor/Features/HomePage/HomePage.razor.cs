using Core.Library.Base;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.BusinessLibrary.Interfaces;
using IPSTemplate.Dal.Models.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.HomePage
{
    public partial class HomePage
    {

        [Inject] UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; } = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        [Inject] private IUserService UserService { get; set; } = default!;

        private Guid UserId { get; set; }

        private TEUserBO User { get; set; } = default!;

        private string UserRole { get; set; } = string.Empty;

        private int UsersCount { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            var user = (await AuthStat).User;

            if (user.Identity?.IsAuthenticated == true)
            {
                UserId = new Guid(userManager.GetUserId(user));
                User = await TEUserGetCommand.GetUserAsync(UserId, DataPortalFactory);

                if (user.IsInRole("Administrator"))
                {
                    UserRole = "Skrbnik";
                }
                else
                {
                    UserRole = "Uporabnik";
                }
            }
        }

    }
}
