using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //one-to-many relation 
            builder.HasOne<Grade>(t => t.Grade).WithMany(c => c.Students).HasForeignKey(t => t.GradeId);

            //relationship  many- to-many
            builder.HasMany(t => t.Courses).WithMany(c => c.Students)
                                 .UsingEntity(t => t.ToTable("StudentsCourses"));
        }
    }
}
