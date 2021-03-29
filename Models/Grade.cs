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
            //Teachers = new List<User>();
            //Students = new List<User>();
        }

        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }


        public virtual ICollection<Course> Courses { get; set; }
        //public virtual ICollection<User> Teachers { get; set; }
        //public virtual ICollection<User> Students { get; set; }

    }
}
