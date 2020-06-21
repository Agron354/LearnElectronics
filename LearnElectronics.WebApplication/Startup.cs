using AutoMapper;
using LearnElectronics.Database;
using LearnElectronics.Services.IoC;
using LearnElectronics.Services.MappingProfile;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("Server=tcp:learnelectronics.database.windows.net,1433;Initial Catalog=LearnElectronics;Persist Security Info=False;User ID=Agron354;Password=LoLkan123121;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
            services.AddCors(options =>
            {
                options.AddPolicy("CORS", builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc()
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Use((context, next) =>
            {
                context.Response.Headers["Access-Control-Allow-Origin"] = "http://localhost:3000";
                context.Response.Headers["Access-Control-Allow-Credentials"] = "true";
                return next.Invoke();
            });
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseCors("CORS");
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
