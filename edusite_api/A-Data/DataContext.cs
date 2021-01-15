using Microsoft.EntityFrameworkCore;
using Models;
using Configurations;

namespace edusite_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }
        public DbSet<Account> Accounts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
        }
    }
}