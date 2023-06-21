
using Core.Library.Base;
using IPSBlazor.Components;
using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Borrowings;

using IPSTemplate.Dal.Models.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace IPSTemplate.UI.Blazor.Features.Borrowings
{
    public partial class BorrowingsList
    {
        [Parameter] public EventCallback<TEBorrowingsInfo> HandleReturn { get; set; }
        [Parameter] public EventCallback<TEBorrowingsInfo> HandleExtend { get; set; }

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject]
        UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [Inject] NotificationService NotificationService { get; set; } = default!;

        public IEnumerable<TEBorrowingsInfo> CurentBorrowings { get; set; } = default!;

        public IEnumerable<TEBorrowingsInfo> HistoryBorrowings { get; set; } = default!;

        public Guid UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == true)
            {
                UserId = Guid.Parse(userManager.GetUserId(user));
            }

            await LoadData();
        }

        public async Task LoadData()
        {
            var request = new CslaRequest
            {
                Include = new string[] { "BookCopy", "BookCopy.Book", "User" }
            };

            CurentBorrowings = await TEBorrowingsRL.GetByUserIdAsync(UserId, false, DataPortalFactory);
            CurentBorrowings = CurentBorrowings.OrderByDescending(p => p.StartBorrowing);
            HistoryBorrowings = await TEBorrowingsRL.GetByUserIdAsync(UserId, true, DataPortalFactory);
            HistoryBorrowings = HistoryBorrowings.OrderByDescending(p => p.EndBorrowing);
        }

        public async Task ShowMessage(string message)
        {
            await Task.Delay(500);
            NotificationService.ShowSuccess(message);
        }
    }
}
