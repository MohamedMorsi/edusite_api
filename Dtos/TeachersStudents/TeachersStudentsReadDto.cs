using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersStudents
{
    public class TeachersStudentsReadDto
    {
        public int TeacherId { get; set; }
        public Dtos.Teacher.TeacherReadDto Teacher { get; set; }

        public int StudentId { get; set; }
        public Dtos.Student.StudentReadDto Student { get; set; }

    }
}