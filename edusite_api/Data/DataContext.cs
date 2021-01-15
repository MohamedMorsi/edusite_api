using Microsoft.EntityFrameworkCore;
using Auth_API.Models;
using Auth_API.Data.Configuration;

namespace Auth_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CurrentActiveUser> CurrentActiveUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TenantConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new CurrentActiveUserConfiguration());
        }
    }
}