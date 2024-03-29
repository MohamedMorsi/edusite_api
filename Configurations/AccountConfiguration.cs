﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.Property(s => s.UserName).IsRequired(true);
            builder.Property(s => s.Password).IsRequired(true);
            builder.Property(s => s.Language).HasDefaultValue("en").IsRequired(true);
            builder.Property(s => s.IsActive).HasDefaultValue(true).IsRequired(true);
            builder.Property(s => s.CreatedDate).HasDefaultValue(DateTime.Now).IsRequired(true);

            //one-to-many relation 
            //builder.HasOne<Role>(t => t.Role).WithMany(c => c.Accounts).HasForeignKey(t => t.RoleId);


            //relationship  many- to-many
            //builder.HasMany(t => t.Departments).WithMany(c => c.Users)
            //                     .UsingEntity(t => t.ToTable("UsersDepartments"));

            //relationship  one- to-one
            //builder.HasOne<StudentAddress>(s => s.Address)
            //.WithOne(ad => ad.Student)
            //.HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

            //seed Data
            //builder.HasData
            //(
            //  new Account
            //  {
            //   
            //  }
            //);
        }
    }
}
