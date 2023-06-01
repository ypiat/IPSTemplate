using Core.Library.Base;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
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

    private IPSGrid<TEGenreInfo> _genre = default!;

    protected override async Task<TEGenreGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEGenreGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _genre.Rebind();
}
