using Core.Library.Base;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;

namespace IPSTemplate.UI.Blazor.Features.Author;

public partial class AuthorsGrid
    : GridView<AuthorsGrid,
               TEAuthorInfo,
               TEAuthorGridInfo,
               TEAuthorRL,
               TEAuthor>

{
    [Parameter] public EventCallback<TEAuthorInfo> EditClicked { get; set; }

    protected override async Task<TEAuthorGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEAuthorGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }
}
