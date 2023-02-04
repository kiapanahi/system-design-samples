namespace Cerberus.Host.ClientDiscovery;

internal interface IClientRetriever
{
    ValueTask<ApiClient> GetAsync(HttpContext httpContext, CancellationToken cancellationToken);
}
