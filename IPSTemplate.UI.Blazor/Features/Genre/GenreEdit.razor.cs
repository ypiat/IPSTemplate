using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Genre
{
    public partial class GenreEdit : EditView<TEGenreBO, TEGenre>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        List<string> customColorPallete = new List<string>()
        {
            "#007dc3",
            "#adb5bd",
            "#19b698",
            "#ea6153",
            "#f16e3f",
            "#52c3d3",
            "#e9ecef"
        };
    }
}
