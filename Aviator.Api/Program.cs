using AviatorHandler = Aviator.Application.Planes.Create.Handler;
using CreatePlaneCommand = Aviator.Application.Planes.Create.Command;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<AviatorHandler>();

var app = builder.Build();

app.MapPost("/v1/planes", async (AviatorHandler handler, CreatePlaneCommand cmd)
    => await handler.HandleAsync(cmd));

app.Run();
