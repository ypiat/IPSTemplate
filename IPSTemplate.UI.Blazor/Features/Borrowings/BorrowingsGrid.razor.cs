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
using IPSBlazor.Extensions;

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
    private IPSGrid<TEBorrowingsInfo> _refHistory = default!;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

    [Inject]
    NavigationManager navigationManager { get; set; }

    [Inject]
    UserManager<TEIdentityUser> userManager { get; set; } = default!;

    [Inject]
    IDataPortalFactory DataPortalFactory { get; set; } = default!;

 

    protected override async Task<TEBorrowingsGridInfo> GetGridData( MobileCslaRequest request)
    {
        return await TEBorrowingsGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    //protected override async Task<TEBorrowingsGridInfo> GetGridData(string? filter, MobileCslaRequest request)
    //{
    //    return await TEBorrowingsGridInfo.GetGridInfoAsync(false, filter, request, DataPortalFactory);
    //}

    public Guid UserId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;

        if (user.Identity?.IsAuthenticated == true)
        {
            UserId = Guid.Parse(userManager.GetUserId(user));
        }
    }

    private void NavigateToHistory()
    {
        navigationManager.NavigateTo("/borrow/history");
    }

    protected new async Task ReadData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = await TEBorrowingsGridInfo.GetGridInfoAsync(false, request, DataPortalFactory);
        var orderedData = data.Data.OrderByDescending(p => p.StartBorrowing);
        args.Data = orderedData;
        args.Total = data.TotalRowCount;
    }

   

    protected new async Task ReadUserData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = await TEBorrowingsGridInfo.GetGridInfoAsync(false, UserId, request, DataPortalFactory);
        var orderedData = data.Data.OrderByDescending(p => p.StartBorrowing);
        args.Data = orderedData;
        args.Total = data.TotalRowCount;
    }

    protected new async Task ReadUserHistoryData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = await TEBorrowingsGridInfo.GetGridInfoAsync(true, UserId, request, DataPortalFactory);
        var orderedData = data.Data.OrderByDescending(p => p.EndBorrowing);
        args.Data = orderedData;
        args.Total = data.TotalRowCount;
    }


    public void Rebind() => _ref.Rebind();
    public void RebindHistory()
    {
        if (_refHistory != null)
        {
            _refHistory.Rebind();
        } 
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
