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
        public static TEBorrowingsRL GetByUserId(Guid userId, bool isReturned, IDataPortalFactory factory)
        {
            return factory.GetPortal<TEBorrowingsRL>().Fetch(userId, isReturned, false);
        }

        public static TEBorrowingsRL GetBorrowingsByStatus(bool isReturned, IDataPortalFactory factory)
        {
            return factory.GetPortal<TEBorrowingsRL>().Fetch(isReturned, false);
        }

        //public static async Task<TEBorrowingsRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        //{
        //    return await dataPortalFactory.GetPortal<TEBorrowingsRL>().FetchAsync(filter);
        //}

        //public static TEAuthorRL GetListByIds(IEnumerable<Guid> ids, IDataPortalFactory dataPortalFactory)
        //{
        //    return  dataPortalFactory.GetPortal<TEAuthorRL>().Fetch(new MobileList<Guid>(ids));
        //}

        #endregion
        #region Server-side methods
        [Fetch]
        protected void FetchByUserId(Guid id, bool isReturned, bool _, [Inject] IRepository<TEBorrowings, TEBorrowings> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "BookCopy", "BookCopy.Book"  },
                Predicate = PredicateBuilder.True<TEBorrowings>().And(p => p.UserID == id).And(p => p.IsReturned == isReturned)
            };
            //request.Filters = new MobileList<CslaRequestFilter>()
            //{
            //    CslaRequestFilter.CreateNewFilter(nameof(TEUserInfo.Name), typeof(string), 2, value: filter, factory.GetPortal<CslaRequestFilter>())
            //};

            Fetch(request, repository, factory, childFactory);
        }

        [Fetch]
        protected void GetBorrowingsByStatus(bool isReturned, bool _, [Inject] IRepository<TEBorrowings, TEBorrowings> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "BookCopy", "BookCopy.Book", "User" },
                Predicate = PredicateBuilder.True<TEBorrowings>().And(p => p.IsReturned == isReturned)
            };

            Fetch(request, repository, factory, childFactory);
        }

        //[Fetch]
        //protected async Task FetchFilteredList(string? filter, [Inject] IRepository<TEBorrowings, TEBorrowings> repository, [Inject] IChildDataPortalFactory childFactory)
        //{
        //    if (!string.IsNullOrEmpty(filter))
        //        Fetch(p => p.User.Name.Contains(filter) || p.User.Surname.Contains(filter), repository, childFactory);
        //    else
        //        Fetch(repository, childFactory);
        //}

        //[Fetch]
        //protected void GetListByIds(MobileList<Guid> ids, [Inject] IRepository<TEAuthor, TEAuthor> repository, [Inject] IChildDataPortalFactory childFactory)
        //{
        //    Fetch(p => ids.Contains(p.Id), repository, childFactory);
        //}
        #endregion
    }
}
