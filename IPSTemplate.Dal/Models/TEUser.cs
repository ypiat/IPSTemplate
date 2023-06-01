using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEUser : Entity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

    }
}
