using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");


            builder.HasKey(a => a.Id);
            //builder.Property(s => s.UserName).IsRequired(true);
            //builder.Property(s => s.Password).IsRequired(true);
            builder.Property(s => s.LanguageId).HasDefaultValue(1).IsRequired(true);
            builder.Property(s => s.IsActive).HasDefaultValue(true).IsRequired(true);

            //one-to-many relation 
            //builder.HasOne<Tenant>(t => t.Tenant).WithMany(c => c.Users).HasForeignKey(t => t.TenantId).OnDelete(DeleteBehavior.SetNull);


            //relationship  many- to-many
            //builder.HasMany(t => t.Roles).WithMany(c => c.Users)
            //                     .UsingEntity(t => t.ToTable("userroles"));

            //builder.HasMany(t => t.Departments).WithMany(c => c.Users)
            //                     .UsingEntity(t => t.ToTable("UsersDepartments"));

            //seed Data
            //builder.HasData
            //(
            //  new User
            //  {
            //      Id = "a7e7a067-a01c-484c-b22c-9e252c01ae2a",
            //      UserName = "admin",
            //      Email = "mohamed.morsi@efileecm.com",
            //      Password = "P@s$123",
            //      IsActive = true,
            //      LanguageId = (int)Lang.en,
            //      TenantId = null
            //  }
            //);
        }
    }
}
