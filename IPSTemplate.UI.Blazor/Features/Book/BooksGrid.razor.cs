using Core.Library.Base;
using IPSBlazor;
using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSBlazor.Services;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Features.BookCopy;
using IPSTemplate.UI.Blazor.Features.Borrowings;
using IPSTemplate.UI.Blazor.Features.User;
using IPSTemplate.UI.Blazor.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Telerik.Blazor.Components;
using Telerik.SvgIcons;

namespace IPSTemplate.UI.Blazor.Features.Book;

public partial class BooksGrid
    : GridView<BooksGrid,
               TEBookInfo,
               TEBookGridInfo,
               TEBookRL,
               TEBook>

{
    [Parameter] public EventCallback<TEBookInfo> EditClicked { get; set; }
 
    [Parameter] public EventCallback<TEBookInfo> AddClicked { get; set; }

    private IPSGrid<TEBookInfo> _book = default!;
    

    protected override async Task<TEBookGridInfo> GetGridData(MobileCslaRequest request)
    {
        return await TEBookGridInfo.GetGridInfoAsync(request, DataPortalFactory);
    }

    [Inject]
    public NavigationManager _navigationManager { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

    public bool IsMember { get; set; }

    [Inject] NotificationService NotificationService { get; set; } = default!;


    public void RebindBookGrid() => _book.Rebind();

    string? _selectedItemId;
    Guid _selectedBookId;
    Guid _selectedBookCopyId;
    int _bookCopyNumber;
    string? _editCopyViewTitle;
    string? _bookName;
    bool windowEditCopyVisible;
    bool windowBorrowVisible;
    BookCopyGrid _bookCopyGrid = default!;
    BookCopyEdit _editCopyView = default!;
    BorrowingsEdit _borrowView = default!;

    protected override async Task OnInitializedAsync()
    {
        var user = (await authenticationStateTask).User;

        if (user.IsInRole("Member"))
        {
            IsMember = true;
        }
    }



    protected async Task GetAuthors(ReadEventArgs args)
    {
        string? filter = args.Request.GetSingleFilter();
        var authors = await TEAuthorRL.GetFilteredList(filter ?? "", DataPortalFactory);
        args.Data = authors;
        args.Total = authors.Count;
    }


    protected void OpenEditCopyView(TEBookCopyInfo selectedItem)
    {
        
        _editCopyViewTitle = $"Uredi kopijo knjige - {selectedItem.BookName}";
        //_selectedBookId = selectedItem.Id;
        //_bookCopyNumber = selectedItem.BookCopyNumber;
        _selectedItemId = selectedItem.Id.ToString();

        windowEditCopyVisible = true;
    }

    async Task CloseEditCopyView()
    {
        await Task.Delay(1000);
        windowEditCopyVisible = false;
        _selectedItemId = null;
        _bookCopyGrid.RebindBookCopyGrid();
    }

    

    protected void OpenBorrowView(TEBookCopyInfo selectedItem)
    {
        _bookName = selectedItem.BookName;
        _selectedBookCopyId = selectedItem.Id;

        windowBorrowVisible = true;
    }

    async Task CloseBorrowView()
    {
        await Task.Delay(1000);
        windowBorrowVisible = false;
        _selectedItemId = null;
        _bookCopyGrid.RebindBookCopyGrid();
    }



    public Color GetColor(TEBookInfo book)
        
    {
        if (book.GenreColor == "#007dc3")
        {
            return Color.Primary;
        }
        if (book.GenreColor == "#adb5bd")
        {
            return Color.Secondary;
        }
        if (book.GenreColor == "#19b698")
        {
            return Color.Success;
        }
        if (book.GenreColor == "#ea6153")
        {
            return Color.Danger;
        }
        if (book.GenreColor == "#f16e3f")
        {
            return Color.Warning;
        }
        if (book.GenreColor == "#52c3d3")
        {
            return Color.Info;
        }
        if (book.GenreColor == "#e9ecef")
        {
            return Color.Light;
        }
        else
        {
            return Color.Light;
        }

    }


}
