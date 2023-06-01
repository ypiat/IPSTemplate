using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Genre;
using IPSTemplate.Dal.Models;
using System.Collections;

namespace IPSTemplate.BusinessLibrary.BO.User
{
    [Serializable]
    public class TEUserRL : CslaReadOnlyListBase<TEUserRL, TEUserInfo, TEUser>
    {
        public TEUserRL()
        { }

        #region Client-side methods
        public static async Task<TEUserRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        {
            return await dataPortalFactory.GetPortal<TEUserRL>().FetchAsync(filter);
        }

        #endregion
        #region Server-side methods
        [Fetch]
        protected async Task FetchFilteredList(string? filter, [Inject] IRepository<TEUser, TEUser> repository, [Inject] IChildDataPortalFactory childFactory)
        {
                Fetch(repository, childFactory);
        }
        #endregion
    }
}
