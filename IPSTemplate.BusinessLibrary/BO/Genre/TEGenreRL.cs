using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.Dal.Models;
using System.Collections;

namespace IPSTemplate.BusinessLibrary.BO.Genre
{
    [Serializable]
    public class TEGenreRL : CslaReadOnlyListBase<TEGenreRL, TEGenreInfo, TEGenre>
    {
        public TEGenreRL()
        { }

        #region Client-side methods
        public static async Task<TEGenreRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        {
            return await dataPortalFactory.GetPortal<TEGenreRL>().FetchAsync(filter);
        }

        #endregion
        #region Server-side methods
        [Fetch]
        protected async Task FetchFilteredList(string? filter, [Inject] IRepository<TEGenre, TEGenre> repository, [Inject] IChildDataPortalFactory childFactory)
        {
            if (!string.IsNullOrEmpty(filter))
                Fetch(p => p.Name.Contains(filter), repository, childFactory);
            else
                Fetch(repository, childFactory);
        }
        #endregion
    }
}
