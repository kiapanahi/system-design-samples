namespace Cerberus.Host.RateLimitting;

internal static class RateLimiterMiddlewareLoggerExtensions
{
    private static readonly Action<ILogger, string, Exception?> _requestRecieved = LoggerMessage.Define<string>(
        LogLevel.Debug,
        new(101, "request-recieved"),
        "request recieved for path: {Path}");
    public static void RequestRecieved(this ILogger<RateLimiterMiddleware> logger, string path)
    {
        _requestRecieved.Invoke(logger, path, null);
    }
}
