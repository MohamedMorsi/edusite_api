using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Grade
{
    public class GradeUpdateDto
    {
        public GradeUpdateDto()
        {
        }
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    }
}