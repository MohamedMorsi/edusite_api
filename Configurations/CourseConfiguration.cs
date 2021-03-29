using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            //builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);


            //one-to-many relation 
            builder.HasOne<Grade>(t => t.Grade).WithMany(c => c.Courses).HasForeignKey(t => t.GradeId);


            //seedData
            builder.HasData(
                    new Course
                    {
                        CourseId = 1,
                        CourseName = "مادة الرياضيات 1",
                        GradeId = 1,
                    },
                    new Course
                    {
                        CourseId = 2,
                        CourseName = "مادة الرياضيات 2",
                        GradeId = 2,
                    }

                );
        }
    }
}
