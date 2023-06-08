using System.ComponentModel.DataAnnotations;
using System.Text;
using Csla.Blazor;
using IPSBlazor.Components;
using IPSBlazor.Services;
using IPSTemplate.AppServer.Helpers;
using IPSTemplate.AppServer.Services;
using IPSTemplate.BusinessLibrary.Interfaces;
using IPSTemplate.BusinessLibrary.StandardCollections;
using IPSTemplate.Dal.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Telerik.SvgIcons;

namespace IPSTemplate.AppServer.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public partial class Register : ComponentBase
    {
        public class Model
        {
            [Required(ErrorMessage = "Polje E-Mail je obvezno.")]
            [EmailAddress]
            [Display(Name = "E-mail")]
            public string? Email { get; set; }

            [Required(ErrorMessage = "Polje Geslo je obvezno.")]
            [DataType(DataType.Password)]
            [Display(Name = "Geslo")]
            public string? Password { get; set; }

            [Required(ErrorMessage = "Polje Potrdi geslo je obvezno.")]
            [DataType(DataType.Password)]
            [Compare(nameof(Password), ErrorMessage = "'Geslo' in 'Potrdi geslo' se ne ujemata.")]
            [Display(Name = "Potrdi geslo")]
            public string? ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Polje Ime je obvezno.")]
            [Display(Name = "Ime")]
            public string? Name { get; set; }

            [Required(ErrorMessage = "Polje Priimek je obvezno.")]
            [Display(Name = "Priimek")]
            public string? Surname { get; set; }
        }

        private UIActionResult? _actionResult;

        private bool HidePassword { get; set; } = true;

        private bool HideConfirmPassword { get; set; } = true;

        private string PageTitle { get; set; }

        private string ConfirmationMessage { get; set; }

        private string UrlInConfirm { get; set; }

        private string LinkInConfirm { get; set; }

        [Inject] private SignInManager<TEIdentityUser> SignInManager { get; set; } = default!;

        [Inject] private UserManager<TEIdentityUser> UserManager { get; set; } = default!;

        [Inject] private IUserService UserService { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        [Inject] private ILogger<Register> Logger { get; set; } = default!;

        [Inject] private ViewModel<Model> ViewModel { get; set; } = default!;

        [Inject] NotificationService NotificationService { get; set; } = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        bool confirmationVisible = false;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == true && user.IsInRole("Member"))
            {
                NavigationManager.NavigateTo("/");
            }
            else 
            {
                if (user.IsInRole("Administrator"))
                {
                    PageTitle = "Dodaj novega uporabnika";
                    ConfirmationMessage = "Uporabnik je bil uspešno dodan! Pojdi na ";
                    UrlInConfirm = "/user";
                    LinkInConfirm = "pregled uporabnikov.";
                }
                else
                {
                    PageTitle = "Ustvari nov račun";
                    ConfirmationMessage = "Registracja je bila uspešna! Pojdite na ";
                    UrlInConfirm = "/account/sign-in";
                    LinkInConfirm = "prijavo.";
                }

                await ViewModel.RefreshAsync(() => Task.FromResult(new Model()));
                await base.OnInitializedAsync();
            }
        }

        private async Task RegisterUser()
        {
            // Create new user
            var user = new TEIdentityUser
            {
                UserName = ViewModel.Model.Email,
                Email = ViewModel.Model.Email,
                EmailConfirmed = true,
                Name = ViewModel.Model.Name,
                Surname = ViewModel.Model.Surname
            };
            var result = await UserManager.CreateAsync(user, ViewModel.Model.Password);
            if (!result.Succeeded)
            {
                string errors = string.Join("; ", result.Errors.Select(e => e.Description));
                Logger.LogError("Error creating new user ({UnderlyingErrors})", errors);
                _actionResult = new UIActionResult
                {
                    Message = "Error creating new user.",
                    Status = IPSBlazor.Color.Danger
                };
                return;
            }

            await UserService.SaveUsersRoles(user.Id, new() { TEUserRole.Member });

            Logger.LogInformation("User created a new account with password.");

            confirmationVisible = true;

            // Send confirmation email
            //            try
            //            {
            //                string userId = await UserManager.GetUserIdAsync(user);
            //                var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
            //                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //                string callbackUrl = NavigationManager.GetAbsoluteUriWithQueryParameters(
            //                    "/account/confirm-email",
            //                    new Dictionary<string, object?>
            //                    {
            //                    { "area", "Identity" },
            //                    { "userId", userId },
            //                    { "code", code }
            //                    });
            //#if DEBUG
            //                NavigationManager.NavigateTo(callbackUrl);
            //                return;
            //#else
            //                //await DISendConfirmationEmailCommand.ExecuteAsync(ViewModel.Model.Email, callbackUrl);
            //#endif
            //            }
            //            catch
            //            {
            //                await UserManager.DeleteAsync(user);
            //                _actionResult = new UIActionResult
            //                {
            //                    Message = "Error sending confirmation email. Please try again later.",
            //                    Status = IPSBlazor.Color.Danger
            //                };
            //                return;
            //            }

            //            // Redirect the user
            //            if (UserManager.Options.SignIn.RequireConfirmedAccount)
            //            {
            //                NavigationManager.NavigateTo(
            //                    "/account/register-confirmation",
            //                    new Dictionary<string, string?>
            //                    {
            //                        { "email", ViewModel.Model.Email }
            //                    });
            //            }
            //            else
            //            {
            //                await SignInManager.SignInAsync(user, isPersistent: false);
            //                if (!NavigationManager.TryGetQueryParameter("returnUrl", out string? returnUrl))
            //                {
            //                    returnUrl = "/";
            //                }
            //                NavigationManager.NavigateTo(returnUrl!);
            //            }



            return;
        }
    }
}
