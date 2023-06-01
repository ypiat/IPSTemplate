using IPSTemplate.BusinessLibrary.BO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.User
{
    public partial class UserEdit
    {
        [Parameter] public EventCallback ItemSaved { get; set; }
    }
}
