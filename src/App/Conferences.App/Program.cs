using Conference.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapGet("/", () => "Conference API!");

app.UseInfrastructure();
app.Run();
