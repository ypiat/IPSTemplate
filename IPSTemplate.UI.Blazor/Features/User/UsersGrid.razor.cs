using Core.Library.Base;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.User;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;

namespace IPSTemplate.UI.Blazor.Features.User;

public partial class UsersGrid
    : GridView<UsersGrid,
               TEUserInfo,
               TEUserGridInfo,
               TEUserRL,
               TEUser>

{
    [Parameter] public EventCallback<TEUserInfo> EditClicked { get; set; }

    private IPSGrid<TEUserInfo> _user = default!;

    protected override async Task<TEUserGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEUserGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _user.Rebind();
}
