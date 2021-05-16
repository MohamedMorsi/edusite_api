using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Course
{
    public class CourseReadDto
    {
        public CourseReadDto()
        {
        }
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int TeachersCoursesCount { get { return TeachersCourses.Count; } }

        public int StudentsCoursesCount { get { return StudentsCourses.Count; } }

        [Required]
        public bool IsActive { get; set; }

        /// /////////////////////////////////////////////////////////////////////
        public int GradeId { get; set; }
        public Dtos.Grade.GradeReadDto Grade { get; set; }
        public virtual ICollection<Dtos.TeachersCourses.TeachersCoursesReadDto> TeachersCourses { get; set; }
        public virtual ICollection<Dtos.StudentsCourses.StudentsCoursesReadDto> StudentsCourses { get; set; }

    }
}