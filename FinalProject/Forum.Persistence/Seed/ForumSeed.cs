using Forum.Domain.Users;
using Forum.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Persistence.Seed
{
    public static class ForumSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var database = scope.ServiceProvider.GetRequiredService<ForumContext>();

            Migrate(database);

            SeedEverything(database);
        }

        private static void Migrate(ForumContext context)
        {
            context.Database.Migrate();
        }

        private static void SeedEverything(ForumContext context)
        {
            var seeded = false;

            SeedUsers(context, ref seeded);

            if (seeded)
                context.SaveChanges();
        }

        private static void SeedUsers(ForumContext context, ref bool seeded)
        { 

            var users = new List<User>()
            {
                new User
                {
                    FirstName = "Mariam",
                    LastName = "Dzamukashvili",
                    Username = "mdzam",
                    Password = "1",
                    Email = "mdzam@gmail.com",
                    Gender = false,
                    IsAdmin = true,
                    IsBanned = false,
                },
            };

            foreach (var user in users)
            {
                if (context.Users.Any(x => x.Username == user.Username)) continue;

                context.Users.Add(user);

                seeded = true;
            }
        }
    }
}
