﻿using IPSBlazor.Components;
using IPSBlazor.Extensions;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookCopy;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;
using IPSTemplate.UI.Blazor.Base;
using IPSTemplate.UI.Blazor.Features.Publisher;
using Microsoft.AspNetCore.Components.Authorization;
using Telerik.Blazor.Components;

namespace IPSTemplate.UI.Blazor.Features.BookCopy
{
    public partial class BookCopyAdd : EditView<TEBookCopyBO, TEBookCopy>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }

        [Parameter, EditorRequired] public TEBookInfo Book { get; set; } = default!;


        bool windowVisible;
        PublisherEdit _publisherEditView = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        protected IPSComboBox<Guid?, TEBookInfo>? cbxBook = default!;
        protected IPSComboBox<Guid?, TEPublisherInfo> cbxPublisher= default!;

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
            else
            {
                await base.OnInitializedAsync();

                ViewModel.Model.SetBook(Book, DataPortalFactory);

            }     
        }

        async Task CloseEditView()
        {
            await Task.Delay(1000);
            windowVisible = false;
            cbxPublisher.Rebind();
        }

        protected async Task GetPublishers(ReadEventArgs args)
        {
            string? filter = args.Request.GetSingleFilter();
            var publishers = await TEPublisherRL.GetFilteredList(filter ?? "", DataPortalFactory);
            args.Data = publishers;
            args.Total = publishers.Count;
        }
    }
}
