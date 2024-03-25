using ToDo.Application.Repositories;
using ToDo.Application.Services;
using ToDo.Application;
using ToDo.Infrastructure.Users;
using ToDo.Infrastructure;

namespace ToDo.Api.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContextWrapper, ContextWrapper>();
        }
    }
}
