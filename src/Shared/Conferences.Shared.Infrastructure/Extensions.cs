
using Conference.Shared.Infrastructure.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Conferences.App")]
namespace Conference.Shared.Infrastructure
{
    internal static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddControllers()
                .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                });

            return services;
        }

        public static WebApplication UseInfrastructure(this WebApplication app)
        {
            app.MapControllers();
            return app;
        }
    }
}
