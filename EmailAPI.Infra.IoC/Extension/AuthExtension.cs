using EmailAPI.Domain.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmailAPI.Infra.IoC.Extension;

public static class AuthExtension
{
    public static IServiceCollection AddAuthConfig(this IServiceCollection service, IConfiguration configuration)
    {
        service.Configure<AuthSettings>(configuration.GetSection("AuthSettings"));
        return service;
    }
}