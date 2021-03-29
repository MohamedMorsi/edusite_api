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


            //seed Data
            builder.HasData
            (
              new Role
              {
                  Id = "62e4d04f-735f-4575-a23f-5e32439959fe",
                  Name = "Admin",
                  NormalizedName = "Admin".ToUpper(),
                  ConcurrencyStamp = "0e6de312-b570-4957-a994-74a7d042d1fb",
              },
              new Role
              {
                  Id = "f525fa1e-bd78-4b00-b015-1bc4deab7751",
                  Name = "Teacher",
                  NormalizedName = "Teacher".ToUpper(),
                  ConcurrencyStamp = "fdeb3739-def0-4c64-b540-8e97af282f83",
              },
              new Role
              {
                  Id = "b3e794e4-893b-45a0-97e8-9e1a5ff80246",
                  Name = "Student",
                  NormalizedName = "Student".ToUpper(),
                  ConcurrencyStamp = "910f35e2-982e-40bc-ae97-2a3b5bc5291a",
              }
            );
        }
    }
}
