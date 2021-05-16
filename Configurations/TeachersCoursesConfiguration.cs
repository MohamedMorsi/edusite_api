using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class TeachersCoursesConfiguration : IEntityTypeConfiguration<TeachersCourses>
    {
        public void Configure(EntityTypeBuilder<TeachersCourses> builder)
        {
            builder.ToTable("TeachersCourses");

            builder.HasKey(a => new { a.TeacherId, a.CourseId });
            builder.HasOne(a => a.Teacher).WithMany(a => a.TeachersCourses).HasForeignKey(a => a.TeacherId);
            builder.HasOne(a => a.Course).WithMany(a => a.TeachersCourses).HasForeignKey(a => a.CourseId);

        }
    }
}
