﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class RegisterModel
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

        ////////////////////////////////////////////////
        public string RoleId { get; set; }


    }
}