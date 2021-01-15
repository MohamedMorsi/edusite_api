using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions");
            builder.Property(s => s.PermissionName).IsRequired(true);

            //relationship  many- to-many
            builder.HasMany(t => t.Tenants).WithMany(c => c.Permissions)
                                 .UsingEntity(t => t.ToTable("TenantsPermissions"));

            //seed Data
            //builder.HasData
            //(
            //  new Permission
            //  {
            //      PermissionId = Guid.NewGuid(),
            //      PermissionName = "",
            //  }
            //);
        }
    }
}
