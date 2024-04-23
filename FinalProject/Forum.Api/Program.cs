using Forum.Api.Infrastructure.Extensions;
using Forum.Api.Infrastructure.Mapping;
using Forum.Api.Infrastructure.Middlewares;
using Forum.Persistence;
using Forum.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Forum.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddService();
            builder.Services.AddRepository();
            builder.Services.AddDbContext<ForumContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(ConnectionStrings.DefaultConnection))));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.RegisterMaps();


            var app = builder.Build();

            app.UseAuthentication();

            app.UseMiddleware<ExceptionHandlerMiddleware>();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
