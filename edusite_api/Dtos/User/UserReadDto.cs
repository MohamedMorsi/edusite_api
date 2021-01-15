using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Dtos.User
{
    public class UserReadDto
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string Language { get; set; }

        [Column("TenantId")]
        public Guid TenantId { get; set; }
        [ForeignKey("TenantId")]
        public Models.Tenant Tenant { get; set; }
    }
}