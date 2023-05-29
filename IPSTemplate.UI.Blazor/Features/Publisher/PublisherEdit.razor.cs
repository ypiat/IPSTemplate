using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Publisher
{
    public partial class PublisherEdit
    {
        [Parameter] public EventCallback ItemSaved { get; set; }
    }
}
