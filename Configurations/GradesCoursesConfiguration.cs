using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    //public class GradesCoursesConfiguration : IEntityTypeConfiguration<GradesCourses>
    //{
    //    public void Configure(EntityTypeBuilder<GradesCourses> builder)
    //    {
    //        //builder.ToTable("GradesCourses");

    //        builder.HasKey(j => new { j.GradesGradeId, j.CoursesCourseId });
    //        //builder.HasOne(pt => pt.Grade).WithMany(w => w.GradesCourses).HasForeignKey(pt => pt.GradeId);
    //        //builder.HasOne(pt => pt.Course).WithMany(w => w.GradesCourses).HasForeignKey(pt => pt.CourseId);
    //    }
    //}
}
