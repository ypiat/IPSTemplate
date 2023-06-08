//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using Csla.Blazor;
//using IPSTemplate.AppServer.Areas.Identity.Pages.Account;
//using IPSTemplate.AppServer.Helpers;
//using IPSTemplate.Dal.Models.Identity;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.WebUtilities;

//namespace IPSTemplate.AppServer.Areas.Identity.Pages.Account
//{
//    public partial class ResetPassword : ComponentBase
//    {
//        public class Model
//        {
//            [Required]
//            [EmailAddress]
//            [Display(Name = "E-mail")]
//            public string? Email { get; set; }

//            [Required]
//            [DataType(DataType.Password)]
//            [Display(Name = "Password")]
//            public string? Password { get; set; }

//            [Required]
//            [DataType(DataType.Password)]
//            [Compare(nameof(Password))]
//            [Display(Name = "Confirm password")]
//            public string? ConfirmPassword { get; set; }

//            [Required]
//            public string? Code { get; set; }
//        }

//        private bool _showConfirmationMessage;
//        private UIActionResult? _initializationResult;
//        private UIActionResult? _actionResult;

//        [Inject] private UserManager<TEIdentityUser> UserManager { get; set; } = default!;

//        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

//        [Inject] private ILogger<SignIn> Logger { get; set; } = default!;

//        [Inject] private ViewModel<Model> ViewModel { get; set; } = default!;

//        protected override async Task OnInitializedAsync()
//        {
//            if (!NavigationManager.TryGetQueryParameter("code", out string? code))
//            {
//                _initializationResult = new UIActionResult
//                {
//                    Message = "A code must be supplied for password reset.",
//                    Status = IPSBlazor.Color.Danger
//                };
//                return;
//            }

//            await ViewModel.RefreshAsync(() => Task.FromResult(new Model
//            {
//                Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code!))
//            }));

//            await base.OnInitializedAsync();
//        }

//        private async Task ResetUserPassword()
//        {
//            TEIdentityUser user = await UserManager.FindByEmailAsync(ViewModel.Model.Email);
//            if (user is null)
//            {
//                // Don't reveal that the user does not exist
//                _showConfirmationMessage = true;
//                return;
//            }

//            var result = await UserManager.ResetPasswordAsync(user!, ViewModel.Model.Code, ViewModel.Model.Password);
//            if (result.Succeeded)
//            {
//                _showConfirmationMessage = true;
//                return;
//            }

//            string errors = string.Join("; ", result.Errors.Select(e => e.Description));
//            Logger.LogError("Error resetting password for user '{Username}' ({UnderlyingErrors})", user.UserName, errors);

//            _actionResult = new UIActionResult
//            {
//                Message = "Error resetting password.",
//                Status = IPSBlazor.Color.Danger
//            };
//        }
//    }
//}
