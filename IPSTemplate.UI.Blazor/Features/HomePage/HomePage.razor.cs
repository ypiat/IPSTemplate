using Core.Library.Base;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.BusinessLibrary.Interfaces;
using IPSTemplate.Dal.Models;
using IPSTemplate.Dal.Models.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSTemplate.UI.Blazor.Features.HomePage
{
    public partial class HomePage
    {

        [Inject] UserManager<TEIdentityUser> userManager { get; set; } = default!;

        [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; } = default!;

        [Inject] protected IDataPortalFactory DataPortalFactory { get; set; } = default!;

        [Inject] private IUserService UserService { get; set; } = default!;

        private Guid UserId { get; set; }

        private TEUserBO User { get; set; } = default!;

        private string UserRole { get; set; } = string.Empty;

        private int BooksCount { get; set; }

        private int UsersCount { get; set; }

        private int BorrowingsCount { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            var user = (await AuthStat).User;

            if (user.Identity?.IsAuthenticated == true)
            {
                UserId = new Guid(userManager.GetUserId(user));
                User = await TEUserGetCommand.GetUserAsync(UserId, DataPortalFactory);

                if (user.IsInRole("Administrator"))
                {
                    UserRole = "Skrbnik";
                }
                else
                {
                    UserRole = "Uporabnik";
                }

                var request = new CslaRequest { };
                //get count of books
                var books = await TEBookRL.GetBooksListAsync(request, DataPortalFactory);
                BooksCount = books.Count();

                //get count of users
                var users = await TEUserRL.GetListAsync(DataPortalFactory);
                UsersCount = users.Count() - 1;

                //get count of borrowings
                var borrowings = await TEBorrowingsRL.GetListAsync(DataPortalFactory);
                BorrowingsCount = borrowings.Count();
            }
        }

    }
}
