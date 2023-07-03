using Core.Library.Base;
using IPSBlazor;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.Book;
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

    public IPSBlazor.Color GetColor(TEGenreInfo genre)

    {
        if (genre.Color == "#007dc3")
        {
            return IPSBlazor.Color.Primary;
        }
        if (genre.Color == "#adb5bd")
        {
            return IPSBlazor.Color.Secondary;
        }
        if (genre.Color == "#19b698")
        {
            return IPSBlazor.Color.Success;
        }
        if (genre.Color == "#ea6153")
        {
            return IPSBlazor.Color.Danger;
        }
        if (genre.Color == "#f16e3f")
        {
            return IPSBlazor.Color.Warning;
        }
        if (genre.Color == "#52c3d3")
        {
            return IPSBlazor.Color.Info;
        }
        if (genre.Color == "#e9ecef")
        {
            return IPSBlazor.Color.Light;
        }
        else
        {
            return IPSBlazor.Color.Light;
        }

    }
}
