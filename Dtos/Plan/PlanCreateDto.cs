using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Plan
{
    public class PlanCreateDto
    {
        public PlanCreateDto()
        {
        }

        [Required, MaxLength(100)]
        public string PlanName { get; set; }

        public int Cost { get; set; }
        public int MaxStudents { get; set; }
        public int MonthsNumber { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}