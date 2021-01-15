using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Role
{
    public class RoleUpdateDto
    {
        public RoleUpdateDto()
        {
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}