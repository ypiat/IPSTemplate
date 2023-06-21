using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Borrowings
{
    public partial class Borowings
    {
        Guid _selectedBookCopyId;
        string _selectedItemId;
        string _bookName;
        bool windowReturnVisible;
        bool windowExtendVisible;
        BorrowingsReturn _returnView = default!;
        BorrowingsExtend _extendView = default!;
        BorrowingsGrid _grid = default!;
        BorrowingsList _list = default!;

        private bool IsAdmin { get; set; } = false;

        [CascadingParameter] protected Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] NotificationService NotificationService { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.IsInRole("Administrator"))
            {
                IsAdmin = true;
            }
        }

        protected void OpenReturnView(TEBorrowingsInfo selectedItem)
        {
            _bookName = selectedItem.BookCopyBookName;
            _selectedBookCopyId = selectedItem.BookCopyID;
            _selectedItemId = selectedItem.Id.ToString();

            windowReturnVisible = true;
        }

        public async Task ShowMessage(string message)
        {
            await Task.Delay(500);
            NotificationService.ShowSuccess(message);
        }

        async Task CloseReturnView()
        {
            windowReturnVisible = false;
            if (IsAdmin)
            {
                _grid.Rebind();
            }
            else
            {
                await _list.LoadData();
            }
            await ShowMessage("Uspešno ste vrnjili knjigo.");

        }

        protected void OpenExtendView(TEBorrowingsInfo selectedItem)
        {
            _bookName = selectedItem.BookCopyBookName;
            _selectedBookCopyId = selectedItem.BookCopyID;
            _selectedItemId = selectedItem.Id.ToString();

            windowExtendVisible = true;
        }

        async Task CloseExtendView()
        {
            windowExtendVisible = false;
            if (IsAdmin)
            {
                _grid.Rebind();
            }
            else
            {
                await _list.LoadData();
            }
            await ShowMessage("Uspešno ste podaljšali izposojo.");
        }
    }
}
