using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Dtos.Tenant
{
    public class TenantReadDto
    {
        public Guid TenantId { get; set; }
        [Required]
        public string TenantName { get; set; }
        public string TenantImageURL { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public IList<Models.Department> Departments { get; set; }
        public IList<Models.User> Users { get; set; }
        public IList<Models.Permission> Permissions { get; set; }
    }
}