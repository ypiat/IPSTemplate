using Core.Library.Base;
using Csla.Blazor;
using IPSBlazor;
using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Helpers;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.BookCopy;

public partial class BookCopyGrid
    : GridView<BookCopyGrid,
               TEBookCopyInfo,
               TEBookCopyGridInfo,
               TEBookCopyRL,
               TEBookCopy>

{
    [Parameter] public EventCallback<TEBookCopyInfo> CopyEditClicked { get; set; }

    [Parameter] public EventCallback<TEBookCopyInfo> BorrowClicked { get; set; }

    [Parameter, EditorRequired] public TEBookInfo Book { get; set; } = default!;
   
    private IPSGrid<TEBookCopyInfo> _bookCopy = default!;


    protected override async Task<TEBookCopyGridInfo> GetGridData(MobileCslaRequest request)
    {

        return await TEBookCopyGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    protected new async Task ReadData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = TEBookCopyRL.GetByBookId(Book.Id, DataPortalFactory);
        args.Data = data;
        args.Total = data.TotalRowCount;
        TotalRowCount = data.TotalRowCount;
    }

    public void RebindBookCopyGrid() => _bookCopy.Rebind();

}
