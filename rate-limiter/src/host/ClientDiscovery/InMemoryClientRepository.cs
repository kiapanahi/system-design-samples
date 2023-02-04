namespace Cerberus.Host.ClientDiscovery;

internal sealed class InMemoryClientRepository : IClientRepository
{
    private static readonly List<ApiClient> _clients = new()
    {
        new(1, "high-load"),
        new ApiClient(2, "medium-load"),
        new ApiClient(3, "low-load")
    };

    public ValueTask<ApiClient?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var client = _clients.SingleOrDefault(c => c.Name == name);
        return ValueTask.FromResult(client);
    }

    public ValueTask<ApiClient?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        var client = _clients.SingleOrDefault(c => c.Id == id);
        return ValueTask.FromResult(client);
    }
}
