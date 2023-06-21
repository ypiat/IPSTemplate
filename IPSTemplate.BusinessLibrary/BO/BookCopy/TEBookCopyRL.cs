using Core.DAL.Infrastructure;
using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyRL : CslaReadOnlyListBase<TEBookCopyRL, TEBookCopyInfo, TEBookCopy>
    {
        public TEBookCopyRL()
        { }

        #region Client-side methods
        public static TEBookCopyRL GetListByIds(IEnumerable<Guid> ids, IDataPortalFactory dataPortalFactory)
        {
            return dataPortalFactory.GetPortal<TEBookCopyRL>().Fetch(new MobileList<Guid>(ids));
        }

        public static TEBookCopyRL GetByBookId(Guid? bookId, IDataPortalFactory factory)
        {
            return factory.GetPortal<TEBookCopyRL>().Fetch(bookId, false);
        }
        #endregion

        #region Server-side methods
        [Fetch]
        protected void GetListByIds(MobileList<Guid> ids, [Inject] IRepository<TEBookCopy, TEBookCopy> repository, [Inject] IChildDataPortalFactory childFactory)
        {
            Fetch(p => ids.Contains(p.Id), repository, childFactory);
        }

        [Fetch]
        protected void FetchByBookId(Guid id, bool _, [Inject] IRepository<TEBookCopy, TEBookCopy> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "Book", "Publisher" },
                Predicate = PredicateBuilder.True<TEBookCopy>().And(p => p.BookID == id)
            };

            Fetch(request, repository, factory, childFactory);
        }
        #endregion
    }
}
