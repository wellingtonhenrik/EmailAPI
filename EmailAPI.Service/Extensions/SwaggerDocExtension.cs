using Microsoft.OpenApi.Models;

namespace EmailAPI.Service.Extensions;

public static class SwaggerDocExtension
{
    public static IServiceCollection AddSqaggerDoc(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "EmailAPI - Wellington",
                    Description = "API para controle de envio de email",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Wellington",
                        Email = "wellingtonhenrik13@gmail.com",
                    }
                });
        });

        return services;
    }

    public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "EmailAPI"); });

        return app;
    } 
}