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

        //List<string> customColorPallete = new List<string>() 
        //{
        //    "red",
        //    "blue",
        //    "rgb(1,2,3)",
        //    "rgb(250,250,250)",
        //    "rgb(0,250,250)",
        //    "#F5DEB3",
        //    "#FFE4B5",
        //    "#FFE5B4",
        //    "#FED8B1",
        //    "#FFDAB9",
        //    "#FFE87C",
        //    "#C0C0C0",
        //    "#808080",
        //    "#000000",
        //    "#FF0000",
        //    "#800000",
        //    "#FFFF00",
        //    "#808000",
        //    "#00FF00",
        //    "#008000",
        //    "#008080",
        //    "#0000FF",
        //    "#000080",
        //    "#FF00FF",
        //    "#800080"
        //};
    }
}
