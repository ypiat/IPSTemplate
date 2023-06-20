using Core.Library.Base;
using IPSBlazor;
using IPSBlazor.Components;
using IPSBlazor.Extensions;
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
        if (book.GenreName == "IT")
        {
            return Color.Primary;
        }
        if (book.GenreName == "Poslovna literatura")
        {
            return Color.Info;
        }
        if (book.GenreName == "Psihologija")
        {
            return Color.Success;
        }
        if (book.GenreName == "Ekonomija")
        {
            return Color.Danger;
        }
        else
        {
            return Color.Warning;
        }

    }


}
