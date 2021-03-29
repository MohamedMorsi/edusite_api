using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User : IdentityUser
    {
        public User()
        {
            // Roles = new List<Role>();

        }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int LanguageId { get; set; }
    }
}