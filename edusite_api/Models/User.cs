using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Models
{
    public class User : BaseModel
    {
        public User()
        {
            Departments = new List<Department>();
        }
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
        public Guid TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

    }
}