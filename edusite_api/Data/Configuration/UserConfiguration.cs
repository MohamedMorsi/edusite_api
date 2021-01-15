using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(s => s.UserName).IsRequired(true);
            builder.Property(s => s.Password).IsRequired(true);
            builder.Property(s => s.Language).HasDefaultValue("en").IsRequired(true);
            builder.Property(s => s.IsActive).HasDefaultValue(true).IsRequired(true);
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //one-to-many relation 
            builder.HasOne<Tenant>(t => t.Tenant).WithMany(c => c.Users).HasForeignKey(t => t.TenantId);


            //relationship  many- to-many
            builder.HasMany(t => t.Departments).WithMany(c => c.Users)
                                 .UsingEntity(t => t.ToTable("UsersDepartments"));

            //seed Data
            //builder.HasData
            //(
            //  new User
            //  {
            //      UserId = Guid.NewGuid(),
            //      UserName = "admin",
            //      Email = "admin@efile.com",
            //      Password = "123",
            //      IsActive = true,
            //      Language = "en",
            //      TenantId = Guid.Parse("3bf55bb9-9820-4ccc-9663-a15a23903cca")
            //  }
            //);
        }
    }
}
