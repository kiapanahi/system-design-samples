using Microsoft.AspNetCore.Http.Extensions;

namespace Cerberus.Host.RateLimitting;

public sealed class RateLimiterMiddleware : IMiddleware
{
    private readonly ILogger<RateLimiterMiddleware> _logger;

    public RateLimiterMiddleware(ILogger<RateLimiterMiddleware> logger)
    {
        _logger = logger;
    }
    public Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        _logger.RequestRecieved(context.Request.GetEncodedPathAndQuery());
        return next.Invoke(context);
    }
}
