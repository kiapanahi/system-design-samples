namespace Cerberus.Host.ClientDiscovery;

internal interface IClientRepository
{
    ValueTask<ApiClient?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    ValueTask<ApiClient?> GetByNameAsync(string key, CancellationToken cancellationToken = default);
}
