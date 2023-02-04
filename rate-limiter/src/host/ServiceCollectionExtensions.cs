using Cerberus.Host.ClientDiscovery;

namespace Microsoft.Extensions.DependencyInjection;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCerberusRateLimiter(this IServiceCollection services)
    {
        services.AddScoped<IClientRepository, InMemoryClientRepository>();
        services.AddScoped<IClientRetriever, HeaderClientRetriever>();
        return services;
    }
}
