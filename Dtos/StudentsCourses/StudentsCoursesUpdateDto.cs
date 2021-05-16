using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.StudentsCourses
{
    public class StudentsCoursesUpdateDto
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }
    }
}