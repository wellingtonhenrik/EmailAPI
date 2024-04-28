using EmailAPI.Application.Interface;
using EmailAPI.Application.Service;
using EmailAPI.Domain.Extension;
using EmailAPI.Domain.Interface;
using EmailAPI.Domain.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmailAPI.Infra.IoC.Extension
{
    public static class DependencyInjectorExtension
    {
        public static IServiceCollection AddConfigure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEmailAppService, EmailAppService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IAuthAppService, AuthAppService>();
            services.AddTransient<IAuthService, AuthService>();
            services.Configure<EmailSetings>(configuration.GetSection("EmailSetings"));
            
            return services;
        }
    }
}
