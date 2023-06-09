using Core.DAL.Infrastructure;
using Csla.Blazor;
using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.BusinessLibrary.BO.Identity.UserRole;
using IPSTemplate.Dal.Models.Identity;
using IPSTemplate.UI.Blazor.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using Telerik.SvgIcons;

namespace IPSTemplate.UI.Blazor.Features.User
{
    public partial class UserPasswordChange : ComponentBase
    {
        public class Model
        {
            [Required(ErrorMessage = "Polje Geslo je obvezno")]
            [DataType(DataType.Password)]
            [Display(Name = "Tekoče geslo")]
            public string? CurrentPassword { get; set; }

            [Required(ErrorMessage = "Polje Novo geslo je obvezno")]
            [DataType(DataType.Password)]
            [Display(Name = "Novo geslo")]
            public string? NewPassword { get; set; }

            [Required(ErrorMessage = "Polje Potrdi novo geslo je obvezno")]
            [DataType(DataType.Password)]
            [Compare(nameof(NewPassword), ErrorMessage = "'Novo Geslo' in 'Potrdi novo geslo' se ne ujemata")]
            [Display(Name = "Potrdi novo geslo")]
            public string? ConfirmPassword { get; set; }


        }

        [Parameter] public EventCallback ItemSaved { get; set; }

        [Inject] private ViewModel<Model> ViewModel { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] private UserManager<TEIdentityUser> UserManager { get; set; } = default!;

        [Inject] NotificationService NotificationService { get; set; } = default!;


        private bool IsDisabled => 
            String.IsNullOrEmpty(ViewModel.Model.CurrentPassword)
            || String.IsNullOrEmpty(ViewModel.Model.NewPassword)
            || String.IsNullOrEmpty(ViewModel.Model.ConfirmPassword)
            || ViewModel.Model.NewPassword != ViewModel.Model.ConfirmPassword;

        private bool HideCurrentPassword { get; set; } = true;
        private bool HideNewPassword { get; set; } = true;
        private bool HideConfirmPassword { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == false)
            {
                NavigationManager.NavigateTo("/");
            }
            else
            {
                await ViewModel.RefreshAsync(() => Task.FromResult(new Model()));
                await base.OnInitializedAsync();
                ViewModel.ModelPropertyChanged += async (s, e) => await InvokeAsync(StateHasChanged);
            }
        }

      private async Task ChangePassword()
        {
            var user = (await authenticationStateTask).User;
            var userModel = await UserManager.FindByNameAsync(UserManager.GetUserName(user));

            if (userModel is not null && await UserManager.CheckPasswordAsync(userModel, ViewModel.Model.CurrentPassword))
            {
                if (ViewModel.Model.CurrentPassword == ViewModel.Model.NewPassword)
                {
                    NotificationService.ShowInfo("Novo geslo je isto kot Tekoče geslo. Izberite drugo Novo geslo.");
                }
                else
                {
                    try
                    {
                        await UserManager.ChangePasswordAsync(userModel, ViewModel.Model.CurrentPassword, ViewModel.Model.NewPassword);
                        ViewModel.Model.CurrentPassword = null;
                        ViewModel.Model.NewPassword = null;
                        ViewModel.Model.ConfirmPassword = null;
                        NotificationService.ShowSuccess("Geslo je bilo uspešno spreminjeno!");
                    }
                    catch
                    {
                        NotificationService.ShowError("NAPAKA! Geslo ni bilo mogoče spremeniti.");
                    }
                    
                }
            }
      }

    }
}
