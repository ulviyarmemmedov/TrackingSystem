using TrackingSystem.Repository.IRepository;
using TrackingSystem.Repository;
using TrackingSystem;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using TrackingSystem.DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

internal class Program
{
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddMvc();//x =>
        //{
        //    var policy = new authorizationpolicybuilder().requireauthenticateduser().build();
        //    x.filters.add(new authorizefilter(policy));
        //});


        builder.Services.AddDbContext<TrackingSystemDbContext>();
        //registering repository
        builder.Services.AddScoped<ICountryRepository, CountryRepository>();

        //registering automapper 
        builder.Services.AddAutoMapper(typeof(MappingConfig));        

        builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Program>());

        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
            x =>
            {
                x.LoginPath = "";
                x.AccessDeniedPath = "";                
            });

        
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

        // auth
        app.UseAuthentication();
        app.UseAuthorization();

		app.MapControllerRoute(
			name: "default",
			pattern: "{area:exists}/{controller=CompanyMain}/{action=Index}/{id?}");

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