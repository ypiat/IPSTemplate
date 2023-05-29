using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Genre
{
    [Serializable]
    public class TEGenreGridInfo : CslaReadOnlyGridBase<TEGenreGridInfo, TEGenreRL, TEGenre, TEGenreRL, TEGenreInfo>
    {
        #region Client-side methods

        public static async Task<TEGenreGridInfo> GetGridInfoAsync(MobileCslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEGenreGridInfo>().FetchAsync(request);
        }

        #endregion

        #region Server-side methods

        [Fetch]
        protected async Task FetchGridInfo(MobileCslaRequest request, [Inject] IDataPortalFactory factory)
        {
            Data = await TEGenreRL.GetListAsync(request, factory);
            TotalRowCount = Math.Max(0, Data.TotalRowCount);
        }

        #endregion
    }
}
