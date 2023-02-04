using Cerberus.Host.ClientDiscovery;

namespace Cerberus.Host.RateLimitting;

internal static class RateLimiterMiddlewareLoggerExtensions
{
    private static readonly Action<ILogger, string, ApiClient, Exception?> _requestRecieved =
        LoggerMessage.Define<string, ApiClient>(
            LogLevel.Debug,
            new(101, "request-recieved"),
            "request recieved from client: {Client} path: {Path}");

    public static void RequestRecieved(this ILogger<RateLimiterMiddleware> logger, string path, ApiClient apiClient)
    {
        _requestRecieved.Invoke(logger, path, apiClient, null);
    }
}
