using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Auth_API.Models
{
    public class Tenant : BaseModel
    {
        public Tenant()
        {
            Users = new List<User>();
            Permissions = new List<Permission>();
            Departments = new List<Department>();
        }
        [Key]
        public Guid TenantId { get; set; }
        [Required]
        public string TenantName { get; set; }
        public string TenantImageURL { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

    }
}