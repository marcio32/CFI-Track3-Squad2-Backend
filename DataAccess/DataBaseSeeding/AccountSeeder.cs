using Microsoft.EntityFrameworkCore;


namespace Track3_Squad2.DataAccess.DataBaseSeeding
{
    public class AccountSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>().HasData(

                new User
                {
                    Id:
                    creationData:
                    Money:
                    IsBloqued:
                    user_Id:
                }

                );
        }
    }
}
