using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Role
{
    public class RoleCreateDto
    {
        public Guid RoleId { get; set; }

        public string Name { get; set; }


    }
}