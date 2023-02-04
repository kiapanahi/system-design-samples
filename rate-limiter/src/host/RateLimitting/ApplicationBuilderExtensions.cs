namespace Cerberus.Host.RateLimitting;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UserCerberusRateLimitting(this IApplicationBuilder app)
    {
        app.UseMiddleware<RateLimiterMiddleware>();
        return app;
    }
}
