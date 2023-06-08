using Core.DAL.Infrastructure;
using Core.Library.Base;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Helpers;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.User;

public partial class UsersGrid
    : GridView<UsersGrid,
               TEUserInfo,
               TEUserGridInfo,
               TEUserRL,
               Entity>

{
    [Parameter] public EventCallback<TEUserInfo> EditClicked { get; set; }

    private IPSGrid<TEUserInfo> _user = default!;

    [Inject]
    IDataPortalFactory DataPortalFactory { get; set; } = default!;

    protected override async Task<TEUserGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEUserGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _user.Rebind();

    //protected new async Task ReadData(ReadEventArgs args)
    //{
    //    var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
    //    var data = await TEUserRL.GetListAsync( DataPortalFactory);
        
    //    var dataWitoutAdmin = data.Where(p => p.Name != "Administrator");
    //    var orderedData = dataWitoutAdmin.OrderBy(p => p.Name);
    //    args.Data = orderedData;
    //    args.Total = data.Count - 1;
    //    TotalRowCount = data.Count - 1;
    //    StateHasChanged();
    //}

    protected new async Task ReadData(ReadEventArgs args)
    {
        var request = await args.Request.ConvertToCslaRequestAsync(MobileRequestPortal, RequestSortPortal, RequestFilterPortal);
        var data = await GetGridData(request);
        var dataWitoutAdmin = data.Data.Where(p => p.Name != "Administrator");
        var orderedData = dataWitoutAdmin.OrderBy(p => p.Name);
        args.Data = orderedData;
        args.Total = data.TotalRowCount;
    }
}
