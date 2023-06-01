using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEPublisher : Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

        
        [MaxLength(100)]
        public string Email { get; set; }

    }
}
