using Core.DAL.Infrastructure;
using Core.Library.Base;
using Csla.DataPortalClient;
using IPSBlazor;
using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using Telerik.DataSource;
using Telerik.DataSource.Extensions;
using Telerik.SvgIcons;

namespace IPSTemplate.UI.Blazor
{
    public partial class Index
    {
        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        public TEBookRL ListViewData { get; set; } = default!;
        public IEnumerable<TEBookInfo> FilteredList { get; set; } = default!;
        public TEGenreRL GenreList { get; set; } = default!;

        private const int _defaultPage = 1;
        private int Page { get; set; } = _defaultPage;

        protected IPSTextBox _filterNameBox = default!;
        protected IPSTextBox _filterAuthorBox = default!;
        protected IPSComboBox<Guid?, TEGenreInfo> _filterGenreBox = default!;


        private string FilterNameText { get; set; } = string.Empty;
        private string FilterAuthorText { get; set; } = string.Empty;
        private string FilterGenreText { get; set; } = string.Empty;

        private bool ShowMessage = false;

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; } = default!;
        private bool EnableBookSearch = true;

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            var user = (await AuthStat).User;
            if (user.IsInRole("Administrator"))
            {
                EnableBookSearch = false;
            }
            await LoadData();
            await GetGenres();

        }

        private async Task LoadData()
        {
            var request = new CslaRequest
            {
                Include = new string[] { "Genre" }
            };

            ListViewData = await TEBookRL.GetBooksListAsync(request, DataPortalFactory);
            FilteredList = ListViewData;
        }

        protected async Task GetGenres()
        {
            GenreList = await TEGenreRL.GetListAsync(DataPortalFactory);
        }

        private void SearchGenres(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var genres = GenreList.Where(p => p.Name.ToLower().Contains(filter ?? "".ToLower()));
            args.Data = genres;
            args.Total = genres.Count();
        }

        private void FilterBooks()
        {
            ShowMessage = false;
            FilteredList = ListViewData;

            if (FilterNameText != string.Empty)
            {
                FilteredList = FilteredList.Where(p => p.Name.ToLower().Contains(FilterNameText.ToLower()));
            }

            if (FilterAuthorText != string.Empty)
            {
                FilteredList = FilteredList.Where(p => p.AuthorNames.ToLower().Contains(FilterAuthorText.ToLower()));
            }

            if (FilterGenreText != string.Empty)
            {
                FilteredList = FilteredList.Where(p => p.GenreName.ToLower().Equals(FilterGenreText.ToLower()));
            }

            if (FilteredList.Count() == 0)
            {
                ShowMessage = true;
            }

            Page = _defaultPage;
        }



        private void SetNameFilter()
        {
            FilterNameText = _filterNameBox.Value;
            FilterBooks();
        }

        private void SetAuthorFilter()
        {
            FilterAuthorText = _filterAuthorBox.Value;
            FilterBooks();
        }

        private void SetGenreFilter()
        {
            FilterGenreText = string.Empty;
            var genreId = _filterGenreBox.Value;
            var genre = GenreList.Where(p => p.Id == genreId).Select(p => p.Name);

            foreach (var item in genre)
            {
                FilterGenreText = item.ToString();
            }

            FilterBooks();
        }



        private void ClearFilter()
        {
            FilterNameText = string.Empty;
            FilterAuthorText = string.Empty;
            _filterGenreBox.Value = null;
            FilteredList = ListViewData;
        }


        public IPSBlazor.Color GetColor(TEBookInfo book)

        {
            if (book.GenreColor == "#007dc3")
            {
                return IPSBlazor.Color.Primary;
            }
            if (book.GenreColor == "#adb5bd")
            {
                return IPSBlazor.Color.Secondary;
            }
            if (book.GenreColor == "#19b698")
            {
                return IPSBlazor.Color.Success;
            }
            if (book.GenreColor == "#ea6153")
            {
                return IPSBlazor.Color.Danger;
            }
            if (book.GenreColor == "#f16e3f")
            {
                return IPSBlazor.Color.Warning;
            }
            if (book.GenreColor == "#52c3d3")
            {
                return IPSBlazor.Color.Info;
            }
            if (book.GenreColor == "#e9ecef")
            {
                return IPSBlazor.Color.Light;
            }
            else
            {
                return IPSBlazor.Color.Light;
            }

        }
    }
}
