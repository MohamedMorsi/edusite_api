using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course : BaseModel
    {
        public Course()
        {
            TeachersCourses = new List<TeachersCourses>();
            StudentsCourses = new List<StudentsCourses>();
        }
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int TeachersCoursesCount { get { return TeachersCourses.Count; } }
        public int StudentsCoursesCount { get { return StudentsCourses.Count; } }
        [Required]
        public bool IsActive { get; set; }

        /// ////////////////////////////////////////////////////////////////////////////////
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public virtual ICollection<TeachersCourses> TeachersCourses { get; set; }
        public virtual ICollection<StudentsCourses> StudentsCourses { get; set; }

    }
}
