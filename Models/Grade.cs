using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Grade : BaseModel
    {
        public Grade()
        {
            Courses = new List<Course>();
            Students = new List<Student>();
            TeachersGrades = new List<TeachersGrades>();
        }

        [Key]
        public int Id { get; set; }
        public string GradeName { get; set; }
        public int CoursesCount { get { return Courses.Count; } }
        [Required]
        public bool IsActive { get; set; }
        /// ///////////////////////////////////////////////////////////////////
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<TeachersGrades> TeachersGrades { get; set; }

    }
}
