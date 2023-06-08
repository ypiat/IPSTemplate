using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEBook : Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Guid? GenreID { get; set; }
        public virtual TEGenre Genre { get; set; }

        [MaxLength(100)]
        public string? Language { get; set; }

        public int? PageAmount { get; set; }

        public int BookIndex { get; set; }
    }
}
