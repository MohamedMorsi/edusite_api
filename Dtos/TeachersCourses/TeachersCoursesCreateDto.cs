using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersCourses
{
    public class TeachersCoursesCreateDto
    {
        public int TeacherId { get; set; }

        public int CourseId { get; set; }
    }
}