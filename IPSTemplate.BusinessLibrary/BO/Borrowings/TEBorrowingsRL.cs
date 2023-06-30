using Core.DAL.Infrastructure;
using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;
using System.Collections;

namespace IPSTemplate.BusinessLibrary.BO.Borrowings
{
    [Serializable]
    public class TEBorrowingsRL : CslaReadOnlyListBase<TEBorrowingsRL, TEBorrowingsInfo, TEBorrowings>
    {
        public TEBorrowingsRL()
        { }

        #region Client-side methods
        public static async Task<TEBorrowingsRL> GetByUserIdAsync(Guid userId, bool isReturned, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsRL>().FetchAsync(userId, isReturned, false);
        }

        public static async Task<TEBorrowingsRL> GetByBookCopyIdAsync(Guid Id, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsRL>().FetchAsync(Id, false);
        }
        #endregion

        #region Server-side methods
        [Fetch]
        protected Task FetchByUserIdAsync(Guid id, bool isReturned, bool _, [Inject] IRepository<TEBorrowings, TEBorrowings> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "BookCopy", "BookCopy.Book", "User" },
                Predicate = PredicateBuilder.True<TEBorrowings>().And(p => p.UserID == id).And(p => p.IsReturned == isReturned)
            };

            Fetch(request, repository, factory, childFactory);
            return Task.CompletedTask;
        }

        [Fetch]
        protected Task FetchByBookCopyIdAsync(Guid id, bool _, [Inject] IRepository<TEBorrowings, TEBorrowings> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "BookCopy", "BookCopy.Book", "User" },
                Predicate = PredicateBuilder.True<TEBorrowings>().And(p => p.BookCopyID == id).And(p => p.IsReturned == false)
            };

            Fetch(request, repository, factory, childFactory);
            return Task.CompletedTask;
        }
        #endregion
    }
}
