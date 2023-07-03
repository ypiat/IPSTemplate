using Core.Library.Base;
using IPSBlazor.Components;
using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.Dal.Models;
using IPSTemplate.Dal.Models.Identity;
using IPSTemplate.UI.Blazor.Features.BookCopy;
using IPSTemplate.UI.Blazor.Features.Borrowings;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.BookCopy
{
    public partial class BookCopyBorrow
    {
        [Parameter] public string ItemId { get; set; } = default!;

        [Inject] UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; } = default!;

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        [Inject] NotificationService NotificationService { get; set; } = default!;

        private TEBookCopyInfo BookCopy { get; set; } = default!;

        private TEBorrowingsInfo BookCopyBorrowing { get; set; } = default!;

        private DateTime StartBorrowDate { get; set; } = DateTime.Now;

        private DateTime EndBorrowDate { get; set; } = DateTime.Now.AddDays(30);

        private bool IsBorrower { get; set; } = false;

        private Guid UserId { get; set; } = default!;

        //variables for IPSWindow
        bool windowBorrowVisible;
        bool windowReturnVisible;
        bool windowExtendVisible;
        Guid _selectedBookCopyId;
        string? _selectedItemId ;
        string? _bookName;
        BorrowingsEdit _borrowView = default!;
        BorrowingsReturn _returnView = default!;
        BorrowingsExtend _extendView = default!;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            var user = (await AuthStat).User;

            if (user.Identity?.IsAuthenticated == true)
            {
                UserId = new Guid(userManager.GetUserId(user));
                await LoadData();
                await CheckBookAvailability();               
            }  
            else
            {
                NavigationManager.NavigateTo($"/account/sign-in?returnUrl={new Uri(NavigationManager.Uri).LocalPath}");
            }
        }

        private async Task LoadData()
        {
            var request = new CslaRequest
            {
                Include = new string[] { "Book" }
            };
            var bookCopyList = await TEBookCopyRL.GetBookCopyListAsync(request, DataPortalFactory);
            var bookCopy = bookCopyList.Where(p => p.Id == new Guid(ItemId));

            foreach (var item in bookCopy)
            {
                BookCopy = item;
            }  
        }

        private async Task CheckBookAvailability()
        {
            if (!BookCopy.IsAvailable)
            {
                var copyBorrowingInfoList = await TEBorrowingsRL.GetByBookCopyIdAsync(new Guid(ItemId), DataPortalFactory);

                foreach (var item in copyBorrowingInfoList)
                {
                    BookCopyBorrowing = item;
                }
                StartBorrowDate = BookCopyBorrowing.StartBorrowing;
                EndBorrowDate = BookCopyBorrowing.EndBorrowing;

                //var user = (await AuthStat).User;
                //UserId = new Guid(userManager.GetUserId(user));
                //check if current user is borrower for this book
                if (UserId == BookCopyBorrowing.UserID)
                {
                    IsBorrower = true;
                }
            }
        }

        protected void OpenBorrowView()
        {
            _bookName = BookCopy.BookName;
            _selectedBookCopyId = BookCopy.Id;
            windowBorrowVisible = true;
        }

        private void CloseBorrowView()
        {
            windowBorrowVisible = false;
            NavigationManager.NavigateTo("/borrowing");
        }

        protected void OpenReturnView()
        {
            _bookName = BookCopy.BookName;
            _selectedBookCopyId = BookCopy.Id;
            _selectedItemId = BookCopyBorrowing.Id.ToString();
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
            
            if(IsBorrower)
            {
                NavigationManager.NavigateTo("/borrowing");
            }
            else
            {
                await LoadData();
                await CheckBookAvailability();
                StateHasChanged();
            }
            
            await ShowMessage("Uspešno ste vrnjili knjigo.");

        }

        protected void OpenExtendView()
        {
            _bookName = BookCopy.BookName;
            _selectedBookCopyId = BookCopy.Id;
            _selectedItemId = BookCopyBorrowing.Id.ToString();

            windowExtendVisible = true;
        }

        async Task CloseExtendView()
        {
            windowExtendVisible = false;
            NavigationManager.NavigateTo("/borrowing");
            await ShowMessage("Uspešno ste podaljšali izposojo.");
        }
    }
}
