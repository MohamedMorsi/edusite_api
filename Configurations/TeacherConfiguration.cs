using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers");
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //relationship  many- to-many
            builder.HasMany(t => t.Grades).WithMany(c => c.Teachers)
                                 .UsingEntity(t => t.ToTable("TeachersGrades"));

            builder.HasMany(t => t.Students).WithMany(c => c.Teachers)
                                 .UsingEntity(t => t.ToTable("TeachersStudents"));

            builder.HasMany(t => t.Courses).WithMany(c => c.Teachers)
                                .UsingEntity(t => t.ToTable("TeachersCourses"));

        }
    }
}
