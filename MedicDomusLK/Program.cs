using MedicDomusLK.Components;
using MedicDomusLK.Components.Account;
using MedicDomusLK.Data;
using MedicDomusLK.Data.Models;
using MedicDomusLK.Repositories;
using MedicDomusLK.Repositories.Contracts;
using MedicDomusLK.Services;
using MedicDomusLK.Services.Contracts;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MedicDomusLK
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddScoped<IdentityUserAccessor>();
            builder.Services.AddScoped<IdentityRedirectManager>();
            builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

            // Configure Identity and Authentication
            ConfigureIdentity(builder.Services);

            // Configure the database context
            ConfigureDatabase(builder.Services, builder.Configuration);

            // Register repositories
            RegisterRepositories(builder.Services);

            // Register application services
            RegisterApplicationServices(builder.Services);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            // Add additional endpoints required by the Identity /Account Razor components.
            app.MapAdditionalIdentityEndpoints();

            app.Run();
        }

        // Configure Identity
        private static void ConfigureIdentity(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

            // Configure the Role Claim Type for Identity
            services.Configure<IdentityOptions>(options =>
            {
                options.ClaimsIdentity.RoleClaimType = ClaimTypes.Role;
            });

            // No need to add explicit authentication here, Identity will handle that
        }

        // Configure Database
        private static void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();
        }

        // Register Repositories
        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<IRepository<ApplicationUser, string>, BaseRepository<ApplicationUser, string>>();
            services.AddScoped<IRepository<Town, int>, BaseRepository<Town, int>>();
            services.AddScoped<IRepository<Service, int>, BaseRepository<Service, int>>();
            services.AddScoped<IRepository<DoctorInfo, int>, BaseRepository<DoctorInfo, int>>();
            services.AddScoped<IRepository<DoctorPatientService, (string, string, int, DateTime)>, BaseRepository<DoctorPatientService, (string, string, int, DateTime)>>();
            services.AddScoped<IRepository<Bill, string>, BaseRepository<Bill, string>>();
            services.AddScoped<IRepository<BillService, (string,int)>,  BaseRepository<BillService, (string,int)>>();
        }

        // Register Application Services
        private static void RegisterApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationUserService, ApplicationUserService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ITownService, TownService>();
            services.AddScoped<IDoctorPatientServiceService, DoctorPatientServiceService>();
            services.AddScoped<IDoctorInfoService, DoctorInfoService>();
            services.AddScoped<IThisBillService, ThisBillService>();
            services.AddScoped<IInvoiceService, InvoiceService>();

            // Register the EmailSender
            services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
        }
    }
}
