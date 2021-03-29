using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.User
{
    public class UserReadDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int LanguageId { get; set; }

        /// //////////////////////////////////////////////////////////////
        /// 
        public string RoleId { get; set; }
        public Dtos.Role.RoleReadDto Role { get; set; }
    }
}