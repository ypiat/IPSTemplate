using Core.Library.Base;
using Csla.Blazor;
using IPSBlazor;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;


namespace IPSTemplate.UI.Blazor.Features.Borrowings;

public partial class BorrowingsGrid
    : GridView<BorrowingsGrid,
               TEBorrowingsInfo,
               TEBorrowingsGridInfo,
               TEBorrowingsRL,
               TEBorrowings>

{
    [Parameter] public EventCallback<TEBorrowingsInfo> HandleReturn { get; set; }
    [Parameter] public EventCallback<TEBorrowingsInfo> HandleExtend { get; set; }

    private IPSGrid<TEBorrowingsInfo> _ref = default!;


    protected override async Task<TEBorrowingsGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEBorrowingsGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _ref.Rebind();

    public Color GetColor(TEBorrowingsInfo borrowing)
    {
        if (borrowing.Status == "Vrnjeno")
        {
            return Color.Success;
        }
        if (borrowing.Status == "V izposoji")
        {
            return Color.Warning;
        }
        else
        {
            return Color.Info;
        }

    }


}
