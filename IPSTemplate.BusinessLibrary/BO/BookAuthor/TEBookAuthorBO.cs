using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.Book;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookAuthor
{
    [Serializable]
    public class TEBookAuthorBO : CslaBusinessBase<TEBookAuthorBO, TEBookAuthor>
    {
        #region Properties
        public static readonly PropertyInfo<Guid> BookIDProperty = RegisterProperty<Guid>(p => p.BookID);
        [Required]
        public Guid BookID
        {
            get => GetProperty(BookIDProperty);
            set => SetProperty(BookIDProperty, value);
        }

        public static readonly PropertyInfo<Guid> AuthorIDProperty = RegisterProperty<Guid>(p => p.AuthorID);
        [Required]
        public Guid AuthorID
        {
            get => GetProperty(AuthorIDProperty);
            set => SetProperty(AuthorIDProperty, value);
        }

        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        #endregion

        #region Client-side methods

        #endregion

        #region Server-side methods

        #endregion
    }
}
