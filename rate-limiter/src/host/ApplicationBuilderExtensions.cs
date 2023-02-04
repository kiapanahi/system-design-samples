using Cerberus.Host.RateLimitting;

namespace Microsoft.Extensions.DependencyInjection;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseCerberusRateLimiter(this IApplicationBuilder app)
    {
        app.UseMiddleware<RateLimiterMiddleware>();
        return app;
    }
}
