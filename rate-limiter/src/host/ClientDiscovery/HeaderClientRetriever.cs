namespace Cerberus.Host.ClientDiscovery;

internal sealed class HeaderClientRetriever : IClientRetriever
{
    private const string ClientHeader = "X-cerberus-clientname";
    private const string DefaultClientToFind = "low-load";
    private readonly IClientRepository _clientRepository;

    public HeaderClientRetriever(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    public async ValueTask<ApiClient> GetAsync(HttpContext httpContext, CancellationToken cancellationToken)
    {
        var header = httpContext.Request.Headers[ClientHeader].FirstOrDefault(DefaultClientToFind);
        var client = await _clientRepository.GetByNameAsync(header!, cancellationToken).ConfigureAwait(false);
        return client!;
    }
}
