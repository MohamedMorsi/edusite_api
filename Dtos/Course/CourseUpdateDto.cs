using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Course
{
    public class CourseUpdateDto
    {
        public CourseUpdateDto()
        {
        }
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        [Required]
        public bool IsActive { get; set; }

        /// //////////////////////////////////////////////////////////////
        public int GradeId { get; set; }

    }
}