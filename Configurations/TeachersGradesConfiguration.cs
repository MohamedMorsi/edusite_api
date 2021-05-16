using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class TeachersGradesConfiguration : IEntityTypeConfiguration<TeachersGrades>
    {
        public void Configure(EntityTypeBuilder<TeachersGrades> builder)
        {
            builder.ToTable("TeachersGrades");

            builder.HasKey(a => new { a.TeacherId, a.GradeId });
            builder.HasOne(a => a.Teacher).WithMany(a => a.TeachersGrades).HasForeignKey(a => a.TeacherId);
            builder.HasOne(a => a.Grade).WithMany(a => a.TeachersGrades).HasForeignKey(a => a.GradeId);

        }
    }
}
