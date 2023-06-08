using Core.Library.Base;
using Csla.Blazor;
using IPSBlazor;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;
using IPSTemplate.Dal.Models.Identity;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System;
using Telerik.Blazor.Components;
using Telerik.SvgIcons;
using Microsoft.AspNetCore.Components;

namespace IPSTemplate.UI.Blazor.Features.Borrowings;

public partial class BorrowingsHistoryGrid
    : GridView<BorrowingsHistoryGrid,
               TEBorrowingsInfo,
               TEBorrowingsGridInfo,
               TEBorrowingsRL,
               TEBorrowings>

{
    [Inject]
    IDataPortalFactory DataPortalFactory { get; set; } = default!;

    [Inject]
    NavigationManager navigationManager { get; set; }

    protected override async Task<TEBorrowingsGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEBorrowingsGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    //protected override async Task<TEBorrowingsGridInfo> GetGridData(string? filter, MobileCslaRequest request)
    //{
    //    return await TEBorrowingsGridInfo.GetGridInfoAsync(false, filter, request, DataPortalFactory);
    //}

    private void NavigateToBorrowings()
    {
        navigationManager.NavigateTo("/");
    }

   

    protected new async Task ReadData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = await TEBorrowingsGridInfo.GetGridInfoAsync(true, request, DataPortalFactory);
        var orderedData = data.Data.OrderByDescending(p => p.EndBorrowing);
        args.Data = orderedData;
        args.Total = data.TotalRowCount;
    }

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
