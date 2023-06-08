using Core.DAL.Infrastructure;
using Core.DALEF.ContextFactory;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Identity.User;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Borrowings
{
    [Serializable]
    public class TEBorrowingsGridInfo : CslaReadOnlyGridBase<TEBorrowingsGridInfo, TEBorrowingsRL, TEBorrowings, TEBorrowingsRL, TEBorrowingsInfo>
    {
        #region Client-side methods

        public static async Task<TEBorrowingsGridInfo> GetGridInfoAsync( MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsGridInfo>().FetchAsync(request);
        }

        public static async Task<TEBorrowingsGridInfo> GetGridInfoAsync(bool? includeReturned, MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsGridInfo>().FetchAsync(includeReturned, request);
        }

        public static async Task<TEBorrowingsGridInfo> GetGridInfoAsync(bool? includeReturned, Guid userId, MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsGridInfo>().FetchAsync(includeReturned, userId, request);
        }





        #endregion

        #region Server-side methods
        [Fetch]
        protected async Task FetchGridInfo( MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            request.Include = new MobileList<string>() { "BookCopy", "BookCopy.Book", "User" };
            Data = await TEBorrowingsRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }


        [Fetch]
        protected async Task FetchGridInfo(bool? includeReturned, MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            request.Include = new MobileList<string>() { "BookCopy", "BookCopy.Book", "User" };
            if (includeReturned.HasValue)
            {
                var statusFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEBorrowingsInfo.IsReturned), typeof(bool), 2, includeReturned, factory.GetPortal<CslaRequestFilter>());
                request.Filters.Add(statusFilter);
            }
            Data = await TEBorrowingsRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }

        [Fetch]
        protected async Task FetchGridInfo(bool? includeReturned, Guid userId, MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            request.Include = new MobileList<string>() { "BookCopy", "BookCopy.Book", "User" };
            if (includeReturned.HasValue)
            {
                var statusFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEBorrowingsInfo.IsReturned), typeof(bool), 2, includeReturned, factory.GetPortal<CslaRequestFilter>());
                var userFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEBorrowings.UserID), typeof(Guid), 2, userId, factory.GetPortal<CslaRequestFilter>());
                request.Filters.Add(statusFilter);
                request.Filters.Add(userFilter);
            }
            Data = await TEBorrowingsRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }



        #endregion
    }
}
