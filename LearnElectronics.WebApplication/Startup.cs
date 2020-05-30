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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("Server=" + Environment.MachineName + ";Database=LearnElectronics;Integrated Security=True;"));
            services.AddCors(options =>
            {
                options.AddPolicy("CORS", builder => builder.WithOrigins("https://reverent-meitner-6e7dbe.netlify.app").AllowAnyHeader().AllowAnyHeader().AllowCredentials());
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
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseCors();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
