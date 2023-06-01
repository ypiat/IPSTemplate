using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.BusinessLibrary.BO.User;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.Borrowings
{
    public partial class BorrowingsEdit : EditView<TEBorrowingsBO, TEBorrowings>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Parameter] public Guid BookCopyId { get; set; }

        protected IPSComboBox<Guid, TEUserInfo> cbxUser = default!;


        protected async Task GetUsers(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var users = await TEUserRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = users;
            args.Total = users.Count;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ViewModel.Model.BookCopyID = BookCopyId;
        }

        private async Task HandleSave()
        {
            ViewModel.Model.OnBorrow();
        }
    }
}
