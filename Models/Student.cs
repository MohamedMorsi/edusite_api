using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : BaseModel
    {
        public Student()
        {
            StudentsCourses = new List<StudentsCourses>();
            TeachersStudents = new List<TeachersStudents>();
        }
        [Key]
        public int StudentId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string MobilePhone2 { get; set; }
        public string UserEmail { get; set; }
        public bool IsActive { get; set; }
        //////////////////////////////////////////////////////////////////////////////////
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public virtual ICollection<StudentsCourses> StudentsCourses { get; set; }
        public virtual ICollection<TeachersStudents> TeachersStudents { get; set; }


    }
}
