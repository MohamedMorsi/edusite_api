using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.TeachersStudents
{
    public class TeachersStudentsUpdateDto
    {
        public int TeacherId { get; set; }

        public int StudentId { get; set; }
    }
}