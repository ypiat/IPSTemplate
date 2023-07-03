using IPSBlazor.Components;
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
using IronBarCode;
using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp.Drawing;
using System.Buffers.Text;
using System.Net.NetworkInformation;
using Telerik.SvgIcons;

namespace IPSTemplate.UI.Blazor.Features.BookCopy
{
    public partial class BookCopyEdit : EditView<TEBookCopyBO, TEBookCopy>
    {
        [Parameter] public EventCallback ItemSaved { get; set; }


        bool windowVisible;
        PublisherEdit _publisherEditView = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        protected IPSComboBox<Guid?, TEBookInfo>? cbxBook = default!;
        protected IPSComboBox<Guid?, TEPublisherInfo> cbxPublisher = default!;

        [CascadingParameter]
        private Task<AuthenticationState> authenticationStateTask { get; set; } = default!;

        [Inject] private NavigationManager NavigationManager { get; set; } = default!;

        private bool HasQRCode { get; set; } = false;

        private string QRCodePath { get; set; } = string.Empty;

        private string TestUrl = string.Empty;


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
            }

            if (ViewModel.Model.QRCodeUrl != "")
            {
                HasQRCode = true;
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

        private void GenerateQRCode()
        {
            var imageUrl = QRCodeWriter.CreateQrCode($"https://localhost:44324/book/copy/borrow/{ItemId}", 500, QRCodeWriter.QrErrorCorrectionLevel.Medium).ToDataUrl();

            ViewModel.Model.QRCodeUrl = imageUrl;

            HasQRCode = true;
        }
    }
}
