using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using My_Final_Project_Staffy.DAL;
using My_Final_Project_Staffy.Models;
using My_Final_Project_Staffy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<LayoutService>();
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(_configuration.GetConnectionString("Default"));
            });
            services.AddIdentity<AppUser, IdentityRole>(opt =>
             {
                 opt.Password.RequiredLength = 7;
                 opt.Password.RequireNonAlphanumeric = false;
                 opt.Password.RequireDigit = true;
                 opt.Password.RequireLowercase = true;
                 opt.Password.RequireUppercase = false;
                 opt.SignIn.RequireConfirmedEmail = true;
                 opt.User.RequireUniqueEmail = true;
                 opt.SignIn.RequireConfirmedPhoneNumber = false;
                 opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 opt.Lockout.MaxFailedAccessAttempts = 3;

                 opt.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnm_1234567890";
             }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}");
            });
        }
    }
}
