using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Teacher
{
    public class TeacherUpdateDto
    {
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
        public virtual ICollection<Dtos.TeachersGrades.TeachersGradesReadDto> TeachersGrades { get; set; }
    }
}