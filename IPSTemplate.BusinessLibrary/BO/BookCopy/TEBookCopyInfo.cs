using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using Core.Library.Base;
using Csla;
using IPSTemplate.BusinessLibrary.BO.Author;
using IPSTemplate.BusinessLibrary.BO.BookAuthor;
using IPSTemplate.Dal.Models;

namespace IPSTemplate.BusinessLibrary.BO.BookCopy
{
    [Serializable]
    public class TEBookCopyInfo : CslaReadOnlyBase<TEBookCopyInfo, TEBookCopy>
    {
        #region Properties

        public static readonly PropertyInfo<int> BookCopyNumberProperty = RegisterProperty<int>(p => p.BookCopyNumber);
        [Range(0, int.MaxValue)]
        [Display(Name = "Številka")]
        public int BookCopyNumber
        {
            get => GetProperty(BookCopyNumberProperty);
            set => LoadProperty(BookCopyNumberProperty, value);
        }


        public static readonly PropertyInfo<Guid> BookIDProperty = RegisterProperty<Guid>(p => p.BookID);
        [Display(Name = "BookId")]
        public Guid BookID
        {
            get => GetProperty(BookIDProperty);
            set => LoadProperty(BookIDProperty, value);
        }

        public static readonly PropertyInfo<TEBookAuthorEL> BookAuthorsProperty = RegisterProperty<TEBookAuthorEL>(p => p.BookAuthors, RelationshipTypes.LazyLoad);
        public TEBookAuthorEL BookAuthors
        {
            get => LazyGetProperty(BookAuthorsProperty, () => GetAuthors(ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(BookAuthorsProperty, value);
        }

        protected TEBookAuthorEL GetAuthors(IDataPortalFactory factory)
        {
            return TEBookAuthorEL.GetByBookId(BookID, factory);
        }

        public static readonly PropertyInfo<TEAuthorRL> AuthorsProperty = RegisterProperty<TEAuthorRL>(p => p.Authors, RelationshipTypes.LazyLoad);
        public TEAuthorRL Authors
        {
            get => LazyGetProperty(AuthorsProperty, () => TEAuthorRL.GetListByIds(BookAuthors.Select(ba => ba.AuthorID), ApplicationContext.GetRequiredService<IDataPortalFactory>()));
            set => LoadProperty(AuthorsProperty, value);
        }

        [Display(Name = "Avtor/ji")]
        public string AuthorNames => String.Join(", ", Authors.Select(a => a.ShowAs));

        public static readonly PropertyInfo<int?> PublishedYearProperty = RegisterProperty<int?>(p => p.PublishedYear);
        [Range(1000, 2023)]
        [Display(Name = "Leto izdaje")]
        public int? PublishedYear
        {
            get => GetProperty(PublishedYearProperty);
            set => LoadProperty(PublishedYearProperty, value);
        }

        public static readonly PropertyInfo<string> BookNameProperty = RegisterProperty<string>(p => p.BookName);
        [Display(Name = "Naslov")]
        public string BookName
        {
            get => GetProperty(BookNameProperty);
            set => LoadProperty(BookNameProperty, value);
        }

        public static readonly PropertyInfo<string> PublisherNameProperty = RegisterProperty<string>(p => p.PublisherName);
        [Display(Name = "Založba")]
        public string PublisherName
        {
            get => GetProperty(PublisherNameProperty);
            set => LoadProperty(PublisherNameProperty, value);
        }

        public static readonly PropertyInfo<bool> IsAvailableProperty = RegisterProperty<bool>(p => p.IsAvailable);
        [Display(Name = "IsAvailable")]
        public bool IsAvailable
        {
            get => GetProperty(IsAvailableProperty);
            set => LoadProperty(IsAvailableProperty, value);
        }

        public static readonly PropertyInfo<string> LocationProperty = RegisterProperty<string>(p => p.Location);
        [Display(Name = "Lokacja")]
        public string Location
        {
            get => GetProperty(LocationProperty);
            set => LoadProperty(LocationProperty, value);
        }

        public static readonly PropertyInfo<bool> ActiveProperty = RegisterProperty<bool>(p => p.Active);
        [Display(Name = "Aktivnost")]
        public bool Active
        {
            get => GetProperty(ActiveProperty);
            set => LoadProperty(ActiveProperty, value);
        }

        [Display(Name = "Aktivnost")]
        public string? ActiveShowAs
        {
            get
            {
                if (Active)
                {
                    return "aktivna";
                }
                else
                {
                    return "ni aktivna";
                }
            }
        }

        public string Status
        {
            get
            {
                if (IsAvailable)
                {
                    return "Na voljo";
                } 
                else 
                {
                    return "Izposojeno";
                }
            }
        }
    }
        #endregion
}
