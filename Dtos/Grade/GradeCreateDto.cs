using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Grade
{
    public class GradeCreateDto
    {
        public GradeCreateDto()
        {
        }
        public string GradeName { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}