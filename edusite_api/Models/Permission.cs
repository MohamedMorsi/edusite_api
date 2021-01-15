using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Models
{
    public class Permission : BaseModel
    {
        public Permission()
        {
            Tenants = new List<Tenant>();

        }
        [Key]
        public Guid PermissionId { get; set; }
        [Required]
        public string PermissionName { get; set; }
        public virtual ICollection<Tenant> Tenants { get; set; }



    }
}