using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class UsersDepartmentsConfiguration : IEntityTypeConfiguration<UsersDepartments>
    {
        public void Configure(EntityTypeBuilder<UsersDepartments> builder)
        {
            builder.ToTable("UsersDepartments");

            //many-to-many relation 
            builder.HasKey(sc => new { sc.UserId, sc.DepartmentId });

            builder.HasOne<User>(sc => sc.User)
                .WithMany(s => s.UsersDepartments)
                .HasForeignKey(sc => sc.UserId);


            builder.HasOne<Department>(sc => sc.Department)
                .WithMany(s => s.UsersDepartments)
                .HasForeignKey(sc => sc.DepartmentId);



            //seed Data
            //builder.HasData
            //(
            //    new UsersDepartments
            //    {

            //    }
            //);
        }
    }
}