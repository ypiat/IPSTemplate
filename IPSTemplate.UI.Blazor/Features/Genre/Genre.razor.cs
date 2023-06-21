using IPSTemplate.BusinessLibrary.BO.Genre;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Genre
{
    public partial class Genre
    {
        string? _selectedItemId;
        string? _editViewTitle;
        bool windowVisible;
        GenresGrid _grid = default!;
        GenreEdit _editView = default!;

        private GenreEdit _genreEdit = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            var user = (await authenticationStateTask).User;

            if (user.Identity?.IsAuthenticated == false || user.IsInRole("Member"))
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected void OpenEditView(TEGenreInfo? selectedItem)
        {
            if (selectedItem is null)
            {
                _editViewTitle = "Dodaj novi žanr";
                _selectedItemId = null;
            }
            else
            {
                _editViewTitle = $"Uredi žanr - {selectedItem.Name}";
                _selectedItemId = selectedItem.Id.ToString();
            }

            windowVisible = true;
        }

        async Task CloseEditView()
        {
            await Task.Delay(1000);
            windowVisible = false;
            _selectedItemId = null;
            _grid.Rebind();
        }
    }
}
