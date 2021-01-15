using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Models
{
    public class Department : BaseModel
    {
        public Department()
        {
            Users = new List<User>();
        }
        [Key]
        public Guid DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public bool IsFileBased { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public Guid TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}