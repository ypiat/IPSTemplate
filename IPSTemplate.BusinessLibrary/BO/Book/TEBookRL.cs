using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.Book
{
    [Serializable]
    public class TEBookRL : CslaReadOnlyListBase<TEBookRL, TEBookInfo, TEBook>
    {
        public TEBookRL()
        { }

        #region Client-side methods
        public static async Task<TEBookRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        {
            return await dataPortalFactory.GetPortal<TEBookRL>().FetchAsync(filter);
        }

        //public static async Task<TEBookRL> GetList(IDataPortalFactory dataPortalFactory)
        //{
        //    return await dataPortalFactory.GetPortal<TEBookRL>().FetchAsync();
        //}
        #endregion
        #region Server-side methods
        [Fetch]
        protected async Task FetchFilteredList(string? filter, [Inject] IRepository<TEBook, TEBook> repository, [Inject] IChildDataPortalFactory childFactory)
        {
            if (!string.IsNullOrEmpty(filter))
                Fetch(p => p.Name.Contains(filter), repository, childFactory);
            else
                Fetch(repository, childFactory);
        }

        //[Fetch]
        //protected async Task FetchList( [Inject] IRepository<TEBook, TEBook> repository, [Inject] IChildDataPortalFactory childFactory)
        //{
        //    Fetch(repository, childFactory);
        //}
        #endregion


    }
}
