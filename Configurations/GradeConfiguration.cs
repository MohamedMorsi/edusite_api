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
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //seedData
            builder.HasData(

                    new Grade
                    {
                        GradeId = 1,
                        GradeName = "الصف الأول الثانوى"
                    },
                    new Grade
                    {
                        GradeId = 2,
                        GradeName = "الصف الثانى الثانوى"
                    },
                    new Grade
                    {
                        GradeId = 3,
                        GradeName = "الصف الثالث الثانوى"
                    }
                );

        }
    }
}
