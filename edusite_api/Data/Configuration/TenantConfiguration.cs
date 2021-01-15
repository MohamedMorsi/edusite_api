using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("Tenants");
            builder.Property(s => s.TenantName).IsRequired(true);
            builder.Property(s => s.IsActive).HasDefaultValue(true).IsRequired(true);
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //builder.HasData
            //(
            //    new Tenant
            //    {
            //        TenantId = Guid.Parse("3bf55bb9-9820-4ccc-9663-a15a23903cca"),
            //        TenantName = "efile",
            //        TenantImageURL = null,
            //        IsActive = true,
            //    }
            //);
        }
    }
}


