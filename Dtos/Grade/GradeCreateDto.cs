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
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }

    }
}