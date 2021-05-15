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
        }
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        [Required]
        public bool IsActive { get; set; }

        /// ////////////////////////////////////////////////////////////////////////////////
        public int GradeId { get; set; }
        public Grade Grade { get; set; }

    }
}
