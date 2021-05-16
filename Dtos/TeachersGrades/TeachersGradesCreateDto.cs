using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersGrades
{
    public class TeachersGradesCreateDto
    {
        public int TeacherId { get; set; }

        public int GradeId { get; set; }
    }
}