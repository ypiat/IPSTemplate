using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;
using IPSTemplate.Dal.Models.Identity;
using IPSTemplate.UI.Blazor.Base;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using Telerik.SvgIcons;

namespace IPSTemplate.UI.Blazor.Features.Borrowings
{
    public partial class BorrowingsEdit : EditView<TEBorrowingsBO, TEBorrowings>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Parameter] public Guid BookCopyId { get; set; }

        [Parameter] public string BookTitle { get; set; }

        protected IPSComboBox<Guid, TEUserInfo> cbxUser = default!;

        public NavigationManager NavigationManager { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject]
        UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [Inject]
        IDataPortalFactory DataPortalFactory { get; set; } = default!;


        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ViewModel.Model.BookCopyID = BookCopyId;

            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == true && user.IsInRole("Member"))
            {
                var userId = userManager.GetUserId(user);

                ViewModel.Model.UserID = Guid.Parse(userId);


                if (ViewModel.Model is null)
                {
                    Error = Localizer["Global_DataNotFound"];
                }
            }
        }

        protected async Task GetUsers(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var users = await TEUserRL.GetFilteredList(filter ?? "", DataPortalFactory);
            var usersWithoutAdmin = users.Where(p => p.Name != "Administrator");
            args.Data = usersWithoutAdmin;
            args.Total = users.Count - 1;
        }

        private async Task HandleSave()
        {
            ViewModel.Model.OnBorrow(); 
        }
    }
}
