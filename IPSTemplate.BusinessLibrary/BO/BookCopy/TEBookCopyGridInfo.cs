using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyGridInfo : CslaReadOnlyGridBase<TEBookCopyGridInfo, TEBookCopyRL, TEBookCopy, TEBookCopyRL, TEBookCopyInfo>
    {
        #region Client-side methods

        public static async Task<TEBookCopyGridInfo> GetGridInfoAsync(MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBookCopyGridInfo>().FetchAsync(request);
        }

        #endregion

        #region Server-side methods

        [Fetch]
        protected async Task FetchGridInfo(MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            request.Include = new MobileList<string>() { "Book", "Publisher" };
            request.IncludeInactive = true;
            Data = await TEBookCopyRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }

        #endregion
    }
}
