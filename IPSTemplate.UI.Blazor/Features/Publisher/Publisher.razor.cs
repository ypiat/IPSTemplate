using IPSTemplate.BusinessLibrary.BO.Publisher;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.Publisher
{
    public partial class Publisher
    {
        string? _selectedItemId;
        string? _editViewTitle;
        bool windowVisible;
        PublishersGrid _grid = default!;
        PublisherEdit _editView = default!;

        private PublisherEdit _publisherEdit = default!;

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


        protected void OpenEditView(TEPublisherInfo? selectedItem)
        {
            if (selectedItem is null)
            {
                _editViewTitle = "Dodaj novo založbo";
                _selectedItemId = null;
            }
            else
            {
                _editViewTitle = $"Uredi založbo - {selectedItem.Name}";
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
