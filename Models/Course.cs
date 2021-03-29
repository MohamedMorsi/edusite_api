﻿using System;
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
            //Students = new List<User>();
            //Teachers = new List<User>();
        }
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }


        /// ////////////////////////////////////////////////////////////////////////////////
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        //public virtual ICollection<User> Teachers { get; set; }
        //public virtual ICollection<User> Students { get; set; }

    }
}
