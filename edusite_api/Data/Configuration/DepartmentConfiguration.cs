using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.Property(s => s.DepartmentName).IsRequired(true);
            builder.Property(s => s.IsActive).HasDefaultValue(true).IsRequired(true);
            builder.Property(s => s.IsFileBased).HasDefaultValue(false).IsRequired(true);
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //one-to-many relation 
            builder.HasOne<Tenant>(t => t.Tenant).WithMany(c => c.Departments).HasForeignKey(t => t.TenantId);

            //seed Data
            //builder.HasData
            //(
            //     new Department
            //     {
            //         DepartmentId = Guid.NewGuid(),
            //         DepartmentName = "Development",
            //         IsFileBased = false,
            //         IsActive = true,
            //         TenantId = Guid.Parse("3bf55bb9-9820-4ccc-9663-a15a23903cca"),
            //     }
            //);
        }
    }
}
