using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersCourses
{
    public class TeachersCoursesReadDto
    {
        public int TeacherId { get; set; }
        public Dtos.Teacher.TeacherReadDto Teacher { get; set; }

        public int CourseId { get; set; }
        public Dtos.Course.CourseReadDto Course { get; set; }

    }
}