﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IPSTemplate.Dal.Models.Identity;

public class TEIdentityUser : IdentityUser<Guid>
{
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(100)]
    public string Surname { get; set; }

    [MaxLength(100)]
    public string PasswordResetToken { get; set; }

    public DateTime? ResetTokenExpireUtc { get; set; }

    public bool Active { get; set; }

    public TEIdentityUser()
    {
        Id = Guid.NewGuid();
        Active = true;
        SecurityStamp = Guid.NewGuid().ToString();
    }

    public TEIdentityUser(string userName) : this()
    {
        UserName = userName;
    }

    public DateTime? DateOfBirth { get; set; }
}
