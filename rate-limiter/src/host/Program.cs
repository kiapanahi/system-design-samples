var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCerberusRateLimiter();

var app = builder.Build();

// this middleware is run before route matching
//  so its called before the "explicit" UseRouting method
app.UseCerberusRateLimiter();

app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();
