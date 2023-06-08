using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace IPSTemplate.Dal.Models;

public class TEUser : Entity
{
    [MaxLength(100)]
    public string FirstName { get; set; }

    [MaxLength(100)]
    public string Lastname { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Email { get; set; }
}
