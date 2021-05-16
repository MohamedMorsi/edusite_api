using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class TeachersStudentsConfiguration : IEntityTypeConfiguration<TeachersStudents>
    {
        public void Configure(EntityTypeBuilder<TeachersStudents> builder)
        {
            builder.ToTable("TeachersStudents");

            builder.HasKey(a => new { a.TeacherId, a.StudentId });
            builder.HasOne(a => a.Teacher).WithMany(a => a.TeachersStudents).HasForeignKey(a => a.TeacherId);
            builder.HasOne(a => a.Student).WithMany(a => a.TeachersStudents).HasForeignKey(a => a.StudentId);

        }
    }
}
