using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEBorrowings : Entity
    {
        [Required]
        public Guid BookCopyID { get; set; }
        public virtual TEBookCopy BookCopy { get; set; }

        [Required]
        public Guid UserID { get; set; }
        public virtual TEUser User { get; set; }

        public DateTime StartBorrowing { get; set; }

        public DateTime EndBorrowing { get; set; }

        public bool IsReturned { get; set; } 

    }
}
