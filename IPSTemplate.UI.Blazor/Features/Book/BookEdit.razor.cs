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
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.Book
{
    public partial class BookEdit : EditView<TEBookBO, TEBook>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; } = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        bool windowVisible;
        AuthorEdit _authorEditView = default!;
        BookEdit _bookEditView = default!;

        protected IPSComboBox<Guid?, TEAuthorInfo>? cbxAuthor = default!;
        protected IPSComboBox<Guid?, TEGenreInfo>? cbxGenre= default!;


        private void CloseEditView()
        {
            windowVisible = false;
            //_bookEditView.
        }

        protected async Task GetAuthors(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            //var selectedIds = new List<Guid>();
            //if (ViewModel.Model.AuthorIds?.Any())
            //{
            //    selectedIds.AddRange(ViewModel.Model.AuthorIds);
            //}
            var authors = await TEAuthorRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = authors;
            args.Total = authors.Count;
        }

        //protected async Task GetPublishers(ReadEventArgs args)
        //{
        //    string? filter = args.Request.GetSingleFilter();
        //    var selectedIds = new List<Guid>();
        //    if (ViewModel.Model.PublisherID.HasValue)
        //    {
        //        selectedIds.Add(ViewModel.Model.PublisherID.Value);
        //    }
        //    var publishers = await TEPublisherRL.GetFilteredList(filter ?? "", DataPortalFactory);
        //    args.Data = publishers;
        //    args.Total = publishers.Count;
        //}

        protected async Task GetGenres(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            //var selectedIds = new List<Guid>();
            //if (ViewModel.Model.GenreID.HasValue)
            //{
            //    selectedIds.Add(ViewModel.Model.GenreID.Value);
            //}
            var genres = await TEGenreRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = genres;
            args.Total = genres.Count;
        }

    }
}
