using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Models
{
    public class CurrentActiveUser : BaseModel
    {
        public CurrentActiveUser()
        {
        }
        [Key]
        public Guid CurrentActiveUserId { get; set; }
        public Guid UserId { get; set; }
        public Guid TenantId { get; set; }
        public string UserToken { get; set; }


    }
}