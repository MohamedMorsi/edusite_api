using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.ToTable("Plans");


            //one-to-many relation 
            //builder.HasOne<Grade>(t => t.Grade).WithMany(c => c.Plans).HasForeignKey(t => t.GradeId);


            ////seedData
            //builder.HasData(
            //        new Plan
            //        {
            //            PlanId = 1,
            //            PlanName = "مادة الرياضيات 1",
            //            GradeId = 1,
            //        },
            //        new Plan
            //        {
            //            PlanId = 2,
            //            PlanName = "مادة الرياضيات 2",
            //            GradeId = 2,
            //        }

            //    );
        }
    }
}
