using Exercise_1_DatabaseFirstMVCCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise_1_DatabaseFirstMVCCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<VoresDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VoresDB")));


            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<VoresDbContext>();
                dbContext.Database.EnsureCreated();
            };


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}