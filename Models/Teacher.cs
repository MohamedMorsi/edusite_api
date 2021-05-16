using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Teacher : BaseModel
    {
        public Teacher()
        {
            TeachersStudents = new List<TeachersStudents>();
            TeachersCourses = new List<TeachersCourses>();
            TeachersGrades = new List<TeachersGrades>();
        }
        [Key]
        public int TeacherId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string MobilePhone2 { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        public virtual ICollection<TeachersGrades> TeachersGrades { get; set; }
        public virtual ICollection<TeachersCourses> TeachersCourses { get; set; }
        public virtual ICollection<TeachersStudents> TeachersStudents { get; set; }

    }
}
