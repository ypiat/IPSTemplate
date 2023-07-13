using Core.Library.Base;
using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.UI.Blazor.Features.BookCopy;
using IPSTemplate.UI.Blazor.Features.Borrowings;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Book
{
    public partial class SingleBookPage
    {
        [Parameter] public string ItemId { get; set; } = default!;

        public TEBookRL AllBooks { get; set; } = default!;

        private TEBookInfo Book { get; set; } = default!;

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; } = default!;

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        bool windowBorrowVisible;
        Guid _selectedBookCopyId;
        string? _bookName; 
        BorrowingsEdit _borrowView = default!;

        BookCopyList _list = default!;
        private bool ShowAlert { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            var user = (await AuthStat).User;
            if (user.IsInRole("Administrator"))
            {
                NavigationManager.NavigateTo("/");
            }

            await LoadData();
        }

        private async Task LoadData()
        {
            var request = new CslaRequest
            {
                Include = new string[] { "Genre" }
            };

            AllBooks = await TEBookRL.GetBooksListAsync(request, DataPortalFactory);
            var book = AllBooks.Where(p => p.Id.ToString() == ItemId);

            foreach (var item in book)
            {
                Book = item;
            }
        }

        protected void OpenBorrowView(TEBookCopyInfo selectedItem)
        {
            _bookName = selectedItem.BookName;
            _selectedBookCopyId = selectedItem.Id;
            windowBorrowVisible = true;
        }

        private void CloseBorrowView()
        {
            windowBorrowVisible = false;
            ShowAlert = true;
        }
    }
}
