using Auth_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth_API.Dtos.Permission
{
    public class PermissionUpdateDto
    {

        [Required]
        public string PermissionName { get; set; }

    }
}