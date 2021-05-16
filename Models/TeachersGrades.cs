using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TeachersGrades
    {

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }

    }
}
