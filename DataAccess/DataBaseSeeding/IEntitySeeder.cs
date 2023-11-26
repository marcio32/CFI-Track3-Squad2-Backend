using Microsoft.EntityFrameworkCore;


namespace Track3_Squad2.DataAccess.DataBaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);

    }
}
