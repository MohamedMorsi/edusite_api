using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Grade
{
    public class GradeReadDto
    {
        public GradeReadDto()
        {
        }
        [Key]
        public int Id { get; set; }
        public string GradeName { get; set; }
        public int StudentsCount { get { return Students.Count; } }
        public int CoursesCount { get { return Courses.Count; } }
        public int TeachersGradesCount { get { return TeachersGrades.Count; } }
        [Required]
        public bool IsActive { get; set; }

        /// /////////////////////////////////////////////////////////////////////
        public List<Dtos.Course.CourseReadDto> Courses { get; set; }
        public virtual ICollection<Dtos.Student.StudentReadDto> Students { get; set; }
        public virtual ICollection<Dtos.TeachersGrades.TeachersGradesReadDto> TeachersGrades { get; set; }

    }
}