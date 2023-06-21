using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.BookCopy
{
    public partial class BookCopyList
    {
        [Parameter, EditorRequired] public TEBookInfo Book { get; set; } = default!;

        [Parameter] public EventCallback<TEBookCopyInfo> BorrowClicked { get; set; }
    }
}
