using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Category
    {
        public Category()
        {
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}