using Microsoft.EntityFrameworkCore;
using Track3_Squad2.DataAccess.DataBaseSeeding;
using Track3_Squad2.Entities;

namespace Track3_Squad2.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
            {
                new AccountSeeder(),
            };

            foreach (var seeder in seeders) 
            {
                seeder.SeedDatabase(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
