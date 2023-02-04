using Cerberus.Host.RateLimitting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCerberusRateLimiter();

var app = builder.Build();

app.UserCerberusRateLimitting();

app.MapGet("/", () => "Hello World!");

app.Run();
