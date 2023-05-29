using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEGenre : Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

    }
}
