using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades");




            //seedData
            builder.HasData(

                    new Grade
                    {
                        Id = 1,
                        GradeName = "الصف الأول الثانوى"
                    },
                    new Grade
                    {
                        Id = 2,
                        GradeName = "الصف الثانى الثانوى"
                    },
                    new Grade
                    {
                        Id = 3,
                        GradeName = "الصف الثالث الثانوى"
                    }
                );

        }
    }
}
