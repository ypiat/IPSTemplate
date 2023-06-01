using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Borrowings
{
    [Serializable]
    public class TEBorrowingsGridInfo : CslaReadOnlyGridBase<TEBorrowingsGridInfo, TEBorrowingsRL, TEBorrowings, TEBorrowingsRL, TEBorrowingsInfo>
    {
        #region Client-side methods

        public static async Task<TEBorrowingsGridInfo> GetGridInfoAsync(MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBorrowingsGridInfo>().FetchAsync(request);
        }

        #endregion

        #region Server-side methods

        [Fetch]
        protected async Task FetchGridInfo(MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            request.Include = new MobileList<string>() { "BookCopy", "BookCopy.Book", "User" };
            Data = await TEBorrowingsRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }

        #endregion
    }
}
