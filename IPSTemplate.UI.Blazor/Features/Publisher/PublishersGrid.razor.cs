using Core.Library.Base;
using IPSBlazor.Components;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;

namespace IPSTemplate.UI.Blazor.Features.Publisher;

public partial class PublishersGrid
    : GridView<PublishersGrid,
               TEPublisherInfo,
               TEPublisherGridInfo,
               TEPublisherRL,
               TEPublisher>

{
    [Parameter] public EventCallback<TEPublisherInfo> EditClicked { get; set; }

    private IPSGrid<TEPublisherInfo> _publisher = default!;

    protected override async Task<TEPublisherGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEPublisherGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    public void Rebind() => _publisher.Rebind();
}
