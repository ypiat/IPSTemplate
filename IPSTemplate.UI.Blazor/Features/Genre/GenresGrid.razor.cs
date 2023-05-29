using Core.Library.Base;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;

namespace IPSTemplate.UI.Blazor.Features.Genre;

public partial class GenresGrid
    : GridView<GenresGrid,
               TEGenreInfo,
               TEGenreGridInfo,
               TEGenreRL,
               TEGenre>

{
    [Parameter] public EventCallback<TEGenreInfo> EditClicked { get; set; }

    protected override async Task<TEGenreGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEGenreGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }
}
