using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Role
{
    public class RoleReadDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}