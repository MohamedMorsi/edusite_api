using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Account : BaseModel
    {
        public Account()
        {
        }
        [Key]
        public int AccountId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Language { get; set; }

    }
}