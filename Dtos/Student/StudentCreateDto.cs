using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Student
{
    public class StudentCreateDto
    {
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
        public string Password { get; set; }
        public string PictureProfile { get; set; }
        public int GradeId { get; set; }
    }
}