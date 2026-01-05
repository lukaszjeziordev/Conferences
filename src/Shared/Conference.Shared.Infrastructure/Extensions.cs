
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Conference.App")]
namespace Conference.Shared.Infrastructure
{
    internal static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddControllers();
            return services;
        }

        public static WebApplication UseInfrastructure(this WebApplication app)
        {
            app.MapControllers();
            return app;
        }
    }
}
