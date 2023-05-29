using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Genre
{
    public partial class GenreEdit
    {
        [Parameter] public EventCallback ItemSaved { get; set; }
    }
}
