using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersGrades
{
    public class TeachersGradesReadDto
    {
        public int TeacherId { get; set; }
        public Dtos.Teacher.TeacherReadDto Teacher { get; set; }

        public int GradeId { get; set; }
        public Dtos.Grade.GradeReadDto Grade { get; set; }

    }
}