using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Publisher
{
    public partial class PublisherEdit : EditView<TEPublisherBO, TEPublisher>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }
    }
}
