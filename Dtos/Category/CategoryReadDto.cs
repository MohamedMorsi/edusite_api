using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Category
{
    public class CategoryReadDto
    {
        public CategoryReadDto()
        {
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string CategoryName { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}