using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class StudentsCoursesConfiguration : IEntityTypeConfiguration<StudentsCourses>
    {
        public void Configure(EntityTypeBuilder<StudentsCourses> builder)
        {
            builder.ToTable("StudentsCourses");

            builder.HasKey(a => new { a.StudentId, a.CourseId });
            builder.HasOne(a => a.Student).WithMany(a => a.StudentsCourses).HasForeignKey(a => a.StudentId);
            builder.HasOne(a => a.Course).WithMany(a => a.StudentsCourses).HasForeignKey(a => a.CourseId);

        }
    }
}
