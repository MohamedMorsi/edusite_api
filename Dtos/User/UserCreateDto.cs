using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.User
{
    public class UserCreateDto
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }

        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int LanguageId { get; set; }

        /// //////////////////////////////////////////////////////////////
        /// 
        public Guid RoleId { get; set; }

    }
}