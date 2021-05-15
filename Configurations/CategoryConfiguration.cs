using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");


            //one-to-many relation 
            //builder.HasOne<Grade>(t => t.Grade).WithMany(c => c.Categorys).HasForeignKey(t => t.GradeId);


            ////seedData
            //builder.HasData(
            //        new Category
            //        {
            //            CategoryId = 1,
            //            CategoryName = "مادة الرياضيات 1",
            //            GradeId = 1,
            //        },
            //        new Category
            //        {
            //            CategoryId = 2,
            //            CategoryName = "مادة الرياضيات 2",
            //            GradeId = 2,
            //        }

            //    );
        }
    }
}
