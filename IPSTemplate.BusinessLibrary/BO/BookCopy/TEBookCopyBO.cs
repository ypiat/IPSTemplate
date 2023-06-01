using System.ComponentModel.DataAnnotations;
using Core.Library.Base;
using Csla;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyBO : CslaBusinessBase<TEBookCopyBO, TEBookCopy>
    {
        #region Properties

        public static readonly PropertyInfo<int> BookCopyNumberProperty = RegisterProperty<int>(p => p.BookCopyNumber);
        [Range(0, int.MaxValue)]
        [Display(Name = "Številka")]
        public int BookCopyNumber
        {
            get => GetProperty(BookCopyNumberProperty);
            set => SetProperty(BookCopyNumberProperty, value);
        }

        public static readonly PropertyInfo<Guid> BookIDProperty = RegisterProperty<Guid>(p => p.BookID);
        [Required]
        [Display(Name = "BookId")]
        public Guid BookID
        {
            get => GetProperty(BookIDProperty);
            set => SetProperty(BookIDProperty, value);
        }

        public static readonly PropertyInfo<string> BookNameProperty = RegisterProperty<string>(p => p.BookName);
        [Display(Name = "Naslov knjigi")]
        public string BookName
        {
            get => GetProperty(BookNameProperty);
            set => LoadProperty(BookNameProperty, value);
        }

        public static readonly PropertyInfo<Guid?> PublisherIDProperty = RegisterProperty<Guid?>(p => p.PublisherID);
        [Required]
        [Display(Name = "PublisherId")]
        public Guid? PublisherID
        {
            get => GetProperty(PublisherIDProperty);
            set => SetProperty(PublisherIDProperty, value);
        }

        public static readonly PropertyInfo<int?> PublishedYearProperty = RegisterProperty<int?>(p => p.PublishedYear);
        [Range(1000, 2023)]
        [Display(Name = "Leto izdaje")]
        public int? PublishedYear
        {
            get => GetProperty(PublishedYearProperty);
            set => SetProperty(PublishedYearProperty, value);
        }

        public static readonly PropertyInfo<bool> IsAvailableProperty = RegisterProperty<bool>(p => p.IsAvailable);
        [Display(Name = "IsAvailable")]
        public bool IsAvailable
        {
            get => GetProperty(IsAvailableProperty);
            set => SetProperty(IsAvailableProperty, value);
        }

        #endregion

        #region Validation rules

        public async Task CheckRulesAsync() => await BusinessRules.CheckRulesAsync();

        #endregion

        #region Client-side methods

        protected override void Create()
        {
            IsAvailable = true;
            base.Create();
        }

        protected override Task CreateAsync(bool isAsync)
        {
            IsAvailable = true;
            return base.CreateAsync(isAsync);
        }

        #endregion

        #region Server-side methods

        #endregion
    }
}
