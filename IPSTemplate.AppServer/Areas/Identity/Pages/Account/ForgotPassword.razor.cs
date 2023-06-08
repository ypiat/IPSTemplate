//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using Csla.Blazor;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.WebUtilities;



//namespace IPSTemplate.AppServer.Areas.Identity.Pages.Account
//{
//    [AllowAnonymous]
//    public partial class ForgotPassword : ComponentBase
//    {
//        public class Model
//        {
//            [Required]
//            [EmailAddress]
//            [Display(Name = "E-mail")]
//            public string? Email { get; set; }
//        }

//        private bool _showEmailSentMessage;

//        [Inject] private UserManager<IdentityUser> UserManager { get; set; } = default!;

//        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

//        [Inject] private ViewModel<Model> ViewModel { get; set; } = default!;

//        protected override async Task OnInitializedAsync()
//        {
//            await ViewModel.RefreshAsync(() => Task.FromResult(new Model()));
//            await base.OnInitializedAsync();
//        }

//        private async Task SendPasswordResetEmail()
//        {
//            IdentityUser user = await UserManager.FindByEmailAsync(ViewModel.Model.Email);
//            if (user is null)
//            {
//                // Don't reveal that the user does not exist or is not confirmed
//                _showEmailSentMessage = true;
//                return;
//            }

//            string code = await UserManager.GeneratePasswordResetTokenAsync(user);
//            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
//            string callbackUrl = NavigationManager.GetUriWithQueryParameters(
//                "/account/reset-password",
//                new Dictionary<string, object?>
//                {
//                    { "area", "Identity" },
//                    { "code", code }
//                });

//            //await DISendPasswordResetEmailCommand.ExecuteAsync(ViewModel.Model.Email, callbackUrl);
//            _showEmailSentMessage = true;
//        }
//    }
//}
