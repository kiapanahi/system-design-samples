using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Cerberus.Host.RateLimitting;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCerberusRateLimiter(this IServiceCollection services)
    {
        services.TryAddSingleton<RateLimiterMiddleware>();
        return services;
    }
}
