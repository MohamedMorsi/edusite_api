using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.Property(s => s.RoleName).IsRequired(true);
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //seed Data
            builder.HasData
            (
              new Role
              {
                  RoleId = 1,
                  RoleName = "Admin"
              },
              new Role
              {
                  RoleId = 2,
                  RoleName = "Teacher"
              },
              new Role
              {
                  RoleId = 3,
                  RoleName = "Student"
              }


            );
        }
    }
}
