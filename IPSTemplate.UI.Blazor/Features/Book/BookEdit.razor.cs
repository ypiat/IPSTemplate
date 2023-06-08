using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Features.Author;
using IPSTemplate.UI.Blazor.Features.Genre;
using Microsoft.AspNetCore.Components.Authorization;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.Book
{
    public partial class BookEdit : EditView<TEBookBO, TEBook>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Parameter] public bool IsAddNew { get; set; }

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        bool windowAuthorVisible;
        bool windowGenreVisible;
        AuthorEdit _authorEditView = default!;
        GenreEdit _genreEditView = default!;

        protected IPSMultiSelect<Guid, TEAuthorInfo> _authorRef = default!;
        protected IPSComboBox<Guid?, TEGenreInfo> _genreRef= default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == false)
            {
                NavigationManager.NavigateTo("/");
            }
            await base.OnInitializedAsync();
        }


        private void CloseEditAuthorView()
        {
            windowAuthorVisible = false;
            _authorRef.Rebind();
        }

        private void CloseEditGenreView()
        {
            windowGenreVisible = false;
            _genreRef.Rebind();
        }

        protected async Task GetAuthors(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var authors = await TEAuthorRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = authors;
            args.Total = authors.Count;
        }



        protected async Task GetGenres(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var genres = await TEGenreRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = genres;
            args.Total = genres.Count;
        }

    }
}
