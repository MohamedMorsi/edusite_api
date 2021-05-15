using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Plan
    {
        public Plan()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string PlanName { get; set; }

        public int Cost { get; set; }
        public int MaxStudents { get; set; }
        public int MonthsNumber { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}