using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.User
{
    [Serializable]
    public class TEUserGridInfo : CslaReadOnlyGridBase<TEUserGridInfo, TEUserRL, TEUser, TEUserRL, TEUserInfo>
    {
        #region Client-side methods

        public static async Task<TEUserGridInfo> GetGridInfoAsync(MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEUserGridInfo>().FetchAsync(request);
        }

        #endregion

        #region Server-side methods

        [Fetch]
        protected async Task FetchGridInfo(MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            Data = await TEUserRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }

        #endregion
    }
}
