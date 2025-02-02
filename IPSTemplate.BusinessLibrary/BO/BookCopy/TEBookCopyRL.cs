﻿using Core.DAL.Infrastructure;
using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.Dal.Models;
using NetTopologySuite.Index.HPRtree;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyRL : CslaReadOnlyListBase<TEBookCopyRL, TEBookCopyInfo, TEBookCopy>
    {
        public TEBookCopyRL()
        { }

        #region Client-side methods
        public static  TEBookCopyRL GetListById(Guid id, IDataPortalFactory dataPortalFactory)
        {
            return dataPortalFactory.GetPortal<TEBookCopyRL>().Fetch(id);
        }

        public static TEBookCopyRL GetByBookId(Guid? bookId, IDataPortalFactory factory)
        {
            return factory.GetPortal<TEBookCopyRL>().Fetch(bookId, false);
        }

        public static async Task<TEBookCopyRL> GetBookCopyListAsync(CslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBookCopyRL>().FetchAsync(request);
        }
        #endregion

        #region Server-side methods
        [Fetch]
        protected void GetListById(Guid id, [Inject] IRepository<TEBookCopy, TEBookCopy> repository, [Inject] IChildDataPortalFactory childFactory)
        {
            Fetch(p => p.Id == id, repository, childFactory);
        }

        [Fetch]
        protected void FetchByBookId(Guid id, bool _, [Inject] IRepository<TEBookCopy, TEBookCopy> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest
            {
                Include = new string[] { "Book", "Publisher" },
                Predicate = PredicateBuilder.True<TEBookCopy>().And(p => p.BookID == id)
            };
            request.IncludeInactive = true;

            Fetch(request, repository, factory, childFactory);
        }

        [Fetch]
        protected Task FetchBooksListAsync(CslaRequest request, bool _, [Inject] IRepository<TEBookCopy, TEBookCopy> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            Fetch(request, repository, factory, childFactory);
            return Task.CompletedTask;
        }
        #endregion
    }
}
