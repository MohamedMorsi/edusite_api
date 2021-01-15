using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Dtos.Tenant
{
    public class TenantCreateDto
    {

        [Required]
        public string TenantName { get; set; }
        public string TenantImageURL { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}