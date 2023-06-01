using Core.Library.Base;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
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

    private IPSGrid<TEAuthorInfo> _author = default!;

    protected override async Task<TEAuthorGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEAuthorGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _author.Rebind();
}
