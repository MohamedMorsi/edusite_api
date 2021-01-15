using Auth_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth_API.Data.Configuration
{
    public class CurrentActiveUserConfiguration : IEntityTypeConfiguration<CurrentActiveUser>
    {
        public void Configure(EntityTypeBuilder<CurrentActiveUser> builder)
        {
            builder.ToTable("CurrentActiveUsers");
        }
    }
}
