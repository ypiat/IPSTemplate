using Core.Library.Base;
using IPSBlazor;
using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.Book;

public partial class BooksGrid
    : GridView<BooksGrid,
               TEBookInfo,
               TEBookGridInfo,
               TEBookRL,
               TEBook>

{
    [Parameter] public EventCallback<TEBookInfo> EditClicked { get; set; }
    [Parameter] public EventCallback<TEBookCopyInfo> CopyEditClicked { get; set; }
    [Parameter] public EventCallback<TEBookInfo> AddClicked { get; set; }
    [Parameter] public EventCallback<TEBookCopyInfo> BorrowClicked { get; set; }

    private IPSGrid<TEBookInfo> _book = default!;
    private IPSGrid<TEBookCopyInfo> _bookCopy = default!;

    protected override async Task<TEBookGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEBookGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void RebindBookGrid() => _book.Rebind();
    public void RebindBookCopyGrid() => _bookCopy.Rebind();


    public Color GetColor(TEBookInfo book)
    {
        if (book.GenreName == "IT")
        {
            return Color.Primary;
        }
        if (book.GenreName == "Poslovna literatura")
        {
            return Color.Info;
        }
        if (book.GenreName == "Classics")
        {
            return Color.Success;
        }
        if (book.GenreName == "Fantasy")
        {
            return Color.Danger;
        }
        else
        {
            return Color.Warning;
        }

    }
}
