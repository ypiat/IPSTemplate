using Core.DAL.Infrastructure;
using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;
using IPSTemplate.Dal.Models.Identity;

namespace IPSTemplate.BusinessLibrary.BO.Identity.User
{
    [Serializable]
    public class TEUserRL : CslaReadOnlyListBase<TEUserRL, TEUserInfo, Entity>
    {
        public TEUserRL()
        {
        }

        #region Client-side methods

        public void EnableEditing(bool enable)
        {
            IsReadOnly = !enable;
        }

        public static async Task<TEUserRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        {
            return await dataPortalFactory.GetPortal<TEUserRL>().FetchAsync(filter);
        }

        public static new async Task<TEUserRL> GetListAsync(IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEUserRL>().FetchAsync(true);
        }

        public static async Task<TEUserRL> GetListAsync(MobileCslaRequest req, IDataPortalFactory factory, bool loadRoles = true)
        {
            return await factory.GetPortal<TEUserRL>().FetchAsync(req, loadRoles);
        }

  

        #endregion

        #region Server-side methods

        [Fetch]
        protected async Task FetchFilteredList(string? filter, [Inject] IRepository<Entity, Entity> repository, [Inject] IChildDataPortalFactory childFactory, [Inject] IDataPortalFactory factory)
        {
            MobileCslaRequest request = factory.GetPortal<MobileCslaRequest>().Create();
            request.Filters = new Csla.Core.MobileList<CslaRequestFilter>()
            {
                CslaRequestFilter.CreateNewFilter(nameof(TEUserInfo.Name), typeof(string), 2, value: filter, factory.GetPortal<CslaRequestFilter>())
            };

            var users = await TEUserGetListCommand.GetUserListAsync(request, factory);

            this.EnableEditing(true);
            using (SuppressListChangedEvents)
            {
                this.AddRange(users.Data);
            }
            this.EnableEditing(false);
        }


        [Fetch]
        protected async Task Fetch(MobileCslaRequest req, bool loadRoles, [Inject] IDataPortalFactory factory)
        {
            var users = await TEUserGetListCommand.GetUserListAsync(req, factory, loadRoles);
            this.EnableEditing(true);
            using (SuppressListChangedEvents)
            {
                this.AddRange(users.Data);
            }
            this.EnableEditing(false);
        }

        [Fetch]
        protected async Task Fetch(bool x, [Inject] IDataPortalFactory factory)
        {
            var users = await TEUserGetListCommand.GetUserListAsync(null, factory);
            this.EnableEditing(true);
            using (SuppressListChangedEvents)
            {
                this.AddRange(users.Data);
            }
            this.EnableEditing(false);
        }

        #endregion
    }
}
