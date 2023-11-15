﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        [Key]
        public int ContactId { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birth { get; set; }
        public OrganizationEntity? Organization { get; set; }
        public int? OrganizationId { get; set; }
    }
}
