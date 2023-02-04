using Cerberus.Host.ClientDiscovery;
using Microsoft.AspNetCore.Http.Extensions;

namespace Cerberus.Host.RateLimitting;

internal sealed class RateLimiterMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RateLimiterMiddleware> _logger;

    public RateLimiterMiddleware(RequestDelegate next,
        ILogger<RateLimiterMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }
    public async Task InvokeAsync(HttpContext context, IClientRetriever clientRetriever)
    {
        var client = await clientRetriever
            .GetAsync(context, CancellationToken.None)
            .ConfigureAwait(false);

        _logger.RequestRecieved(context.Request.GetEncodedPathAndQuery(), client!);

        await _next.Invoke(context).ConfigureAwait(false);
    }
}
