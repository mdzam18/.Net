using Forum.Application.Users;
using Forum.Infrastructure.Users;
using Forum.Persistence;
using Forum.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Forum.UserBanHandler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddSingleton<IUserService, UserService>();
                    services.AddSingleton<IUserRepository, UserRepository>();
                    services.AddDbContext<ForumContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString(nameof(ConnectionStrings.DefaultConnection))), ServiceLifetime.Singleton);
                })
                .Build();

            host.Run();
        }
    }
}