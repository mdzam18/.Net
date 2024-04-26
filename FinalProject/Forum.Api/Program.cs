using Forum.Api.Infrastructure.Auth.JWT;
using Forum.Api.Infrastructure.Extensions;
using Forum.Api.Infrastructure.Mapping;
using Forum.Api.Infrastructure.Middlewares;
using Forum.Persistence;
using Forum.Persistence.Context;
using Forum.Persistence.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Forum.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    In = ParameterLocation.Header,
                    Description = "."
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "bearer"
                                }
                            },
                            new string[] {}
                    }
                });
                //options.SwaggerDoc("v1", new OpenApiInfo
                //{
                //    Title = "Person API",
                //    Version = "v1",
                //    Description = "Api to manage person",
                //    Contact = new OpenApiContact
                //    {
                //        Name = "TBC IT Academy",
                //        Email = "itacademy@tbcbank.com",
                //        Url = new Uri("https://www.tbcacademy.ge/"),
                //    },
                //    //License = OpenApiLicense()
                //});

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                //options.IncludeXmlComments(xmlPath);
               // options.ExampleFilters();
            });
            // Add services to the container.
            builder.Services.AddTokenAuth(builder.Configuration.GetSection(nameof(JWTConfiguration)).GetSection(nameof(JWTConfiguration.Secret)).Value);

            builder.Services.AddService();
            builder.Services.AddRepository();
            builder.Services.AddDbContext<ForumContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(ConnectionStrings.DefaultConnection))));

            builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(nameof(ConnectionStrings)));
            builder.Services.Configure<JWTConfiguration>(builder.Configuration.GetSection(nameof(JWTConfiguration)));
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();
            builder.Services.RegisterMaps();


            var app = builder.Build();

            app.UseAuthentication();
            app.UseAuthorization();

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

            ForumSeed.Initialize(app.Services);

            app.Run();
        }
    }
}
