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
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
        }
        [Key]
        public int TeacherId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string MobilePhone2 { get; set; }
        public string UserEmail { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string PictureProfile { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
