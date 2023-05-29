using IPSTemplate.BusinessLibrary.BO.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Author
{
    public partial class AuthorEdit
    {
        [Parameter] public EventCallback ItemSaved { get; set; }
    }
}
