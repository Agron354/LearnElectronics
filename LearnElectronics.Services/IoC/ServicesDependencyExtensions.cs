using LearnElectronics.Services.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LearnElectronics.Services.IoC
{
    public static class ServicesDependencyExtensions
    {

        public static IServiceCollection InitializeServices(this IServiceCollection services)
        {
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<ILikeService, LikeService>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IThemeService, ThemeService>();
            services.AddTransient<ILectureService, LectureService>();
            return services;
        }
    }
}
