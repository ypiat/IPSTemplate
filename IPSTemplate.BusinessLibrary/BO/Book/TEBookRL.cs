using Core.DAL.Infrastructure;
using Core.DAL.Interface;
using Core.Library.Base;
using Csla;
using Csla.Core;
using IPSTemplate.BusinessLibrary.BO.Borrowings;
using IPSTemplate.BusinessLibrary.BO.Publisher;
using IPSTemplate.Dal.Models;
using System;

namespace IPSTemplate.BusinessLibrary.BO.Book
{
    [Serializable]
    public class TEBookRL : CslaReadOnlyListBase<TEBookRL, TEBookInfo, TEBook>
    {
        public TEBookRL()
        { }

        #region Client-side methods
        //public static async Task<TEBookRL> GetFilteredList(string? filter, IDataPortalFactory dataPortalFactory)
        //{
        //    return await dataPortalFactory.GetPortal<TEBookRL>().FetchAsync(filter);
        //}

        public static async Task<TEBookRL> GetBooksListAsync(CslaRequest request, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBookRL>().FetchAsync(request);
        }

        public static async Task<TEBookRL> GetFilteredListAsync(string? filter, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBookRL>().FetchAsync(filter);
        }

        public static async Task<TEBookRL> GetFilteredListAsync(CslaRequest request, string? filter, IDataPortalFactory factory)
        {
            return await factory.GetPortal<TEBookRL>().FetchAsync(request, filter);
        }

        #endregion
        #region Server-side methods
        //[Fetch]
        //protected async Task FetchFilteredList(string? filter, [Inject] IRepository<TEBook, TEBook> repository, [Inject] IChildDataPortalFactory childFactory)
        //{
        //    if (!string.IsNullOrEmpty(filter))
        //        Fetch(p => p.Name.Contains(filter), repository, childFactory);
        //    else
        //        Fetch(repository, childFactory);
        //}

        [Fetch]
        protected Task FetchBooksListAsync(CslaRequest request, bool _, [Inject] IRepository<TEBook, TEBook> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            //var request = new CslaRequest
            //{
            //    Include = new string[] { "Genre" }
            //};


            Fetch(request, repository, factory, childFactory);
            return Task.CompletedTask;
        }

        [Fetch]
        protected async Task FetchFilteredListAsync(string? filter, bool _, [Inject] IRepository<TEBook, TEBook> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            var request = new CslaRequest();
            //{
            //    Include = new string[] { "Genre" },
            //    Predicate = PredicateBuilder.True<TEBookInfo>().And(p => p.Name.Contains(filter))

            //};

            var nameFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEBookInfo.Name), typeof(bool), 2, filter, factory.GetPortal<CslaRequestFilter>());
            request.Filters.Add(nameFilter);

            Fetch(request, repository, factory, childFactory);
            //return Task.CompletedTask;
        }

        [Fetch]
        protected async Task FetchFilteredListAsync(CslaRequest request, string? filter, bool _, [Inject] IRepository<TEBook, TEBook> repository, [Inject] IDataPortalFactory factory, [Inject] IChildDataPortalFactory childFactory)
        {
            //var request = new CslaRequest
            //{
            //    Include = new string[] { "Genre" },
            //    Predicate = PredicateBuilder.True<TEBookInfo>().And(p => p.Name.Contains(filter))

            //};

            var nameFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEBookInfo.Name), typeof(string), 2, filter, factory.GetPortal<CslaRequestFilter>());
            request.Filters.Add(nameFilter);

            Fetch(request, repository, factory, childFactory);
            //return Task.CompletedTask;
        }
        #endregion


    }
}
