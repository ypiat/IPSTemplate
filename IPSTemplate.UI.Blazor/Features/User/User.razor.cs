using IPSTemplate.BusinessLibrary.BO.Identity.User;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.User
{
    public partial class User
    {
        string? _selectedItemId;
        string? _editViewTitle;
        bool windowVisible;
        UsersGrid _grid = default!;
        UserEdit _editView = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == false || user.IsInRole("Member"))
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected void NavigateToRegister()
        {
            NavigationManager.NavigateTo("/account/register");
        }

        protected void OpenEditView(TEUserInfo? selectedItem)
        {
            _editViewTitle = $"Uredi uporabnika - {selectedItem.DisplayNameLong}";
            _selectedItemId = selectedItem.Id.ToString();
            windowVisible = true;
        }

        async Task CloseEditView()
        {
            await Task.Delay(1000);
            windowVisible = false;
            _selectedItemId = null;
            _grid.Rebind();
        }
    }
}
