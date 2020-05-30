using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.IoC;
using LearnElectronics.Services.MappingProfile;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;


namespace LearnElectronics.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.InitializeServices();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("Server=" + Environment.MachineName + ";Database=LearnElectronics;Integrated Security=True;"));
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                  builder => builder
                      .WithOrigins("http://localhost:3000/")
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                  );
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCookiePolicy();
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseCors(builder => builder.WithOrigins("http://localhost:3000/").AllowAnyMethod().AllowAnyHeader());
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
