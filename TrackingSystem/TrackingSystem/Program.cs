using TrackingSystem.Repository.IRepository;
using TrackingSystem.Repository;
using TrackingSystem;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using TrackingSystem.DAL;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddMvc();

        builder.Services.AddDbContext<TrackingSystemDbContext>();
        //registering repository
        builder.Services.AddScoped<ICountryRepository, CountryRepository>();

        //registering automapper 
        builder.Services.AddAutoMapper(typeof(MappingConfig));

        

        builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Program>());


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}

// Data Source=DESKTOP-IDTEVDF;Initial Catalog=TrackingSystemDB;Integrated Security=True;Trust Server Certificate=True