using Forum.Persistence.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Forum.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("PersonManagement.Web"));
            });

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(option =>
            {
                option.Password.RequireDigit = true;
                option.Password.RequiredLength = 8;
                option.Password.RequireUppercase = true;
                //option.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<AppDbContext>();


            //TODO
            //builder.Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AdminOnly", policy => policy.RequireClaim("Admin"));
            //});

            //builder.Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("DeveloperOnly", policy => policy.RequireRole("Developer"));
            //});

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Account/Login";
                    options.Cookie.Name = "AuthCookie";
                });

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
