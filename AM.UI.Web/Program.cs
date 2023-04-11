using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AM.UI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddSingleton<IServiceFlight, ServiceFlight>(); // 1 seule instance dans toute l'app
            builder.Services.AddScoped<IServiceFlight, ServiceFlight>(); // AddScoope : 1 instance pour chaque requete http
            builder.Services.AddScoped<IServicePlane, ServicePlane>(); // AddScoope : 1 instance pour chaque requete http

            // AddTransient : 1 instance pour chaque appel
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddDbContext<DbContext, AMContext>();
            builder.Services.AddSingleton<Type>(T => typeof(GenericRepository<>));


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
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}