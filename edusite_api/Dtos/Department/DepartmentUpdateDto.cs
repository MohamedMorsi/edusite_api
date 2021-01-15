using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Dtos.Department
{
    public class DepartmentUpdateDto
    {

        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public bool IsFileBased { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public Guid TenantId { get; set; }

    }
}