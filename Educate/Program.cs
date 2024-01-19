using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Educate.Context;
using System.Configuration;
using FluentAssertions.Common;

namespace Educate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<EducateDbContext>(options =>
                        options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
            name: "Admin",
            pattern: "{area:exists}/{controller=Instructor}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}