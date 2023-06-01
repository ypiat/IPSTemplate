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
    public partial class BorrowingsReturn : EditView<TEBorrowingsBO, TEBorrowings>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Parameter] public Guid BookCopyId { get; set; }
        [Parameter] public string BookName { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            ViewModel.Model.BookCopyID = BookCopyId;
        }

        private async Task HandleSave()
        {
            ViewModel.Model.OnReturn();
        }
    }
}
