using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.StudentsCourses
{
    public class StudentsCoursesReadDto
    {
        public int StudentId { get; set; }
        public Dtos.Student.StudentReadDto Student { get; set; }

        public int CourseId { get; set; }
        public Dtos.Course.CourseReadDto Course { get; set; }

    }
}