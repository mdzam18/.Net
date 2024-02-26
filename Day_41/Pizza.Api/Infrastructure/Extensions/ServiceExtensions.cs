using Microsoft.EntityFrameworkCore;
using Pizza.Application.Pizzas;
using Pizza.Application.Repositories;

namespace Pizza.Api.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {

        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<IPizzaService, PizzaService>();
        }

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IPizzaRepository, PizzaRepository>();
        }

        public static void AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<RepositoryDbContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDatabase");
            });
        }

    }
}
