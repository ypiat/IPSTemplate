﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;

namespace IPSTemplate.Dal.Models
{
    public class TEBookCopy : Entity
    {
        [Required]
        public int BookCopyNumber { get; set; }

        [Required]
        public Guid BookID { get; set; }
        public virtual TEBook Book { get; set; }

        [Required]
        public Guid? PublisherID { get; set; }
        public virtual TEPublisher Publisher { get; set; }

        public int? PublishedYear { get; set; }

        public bool IsAvailable { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        public string QRCodeUrl { get; set; }
    }
}
