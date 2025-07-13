<<<<<<< HEAD
using Aviator.Application;
using MediatR;
using CreatePlaneCommand = Aviator.Application.Planes.Create.Command;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();

var app = builder.Build();

app.MapPost("/v1/planes", async (ISender handler, CreatePlaneCommand cmd)
    => await handler.Send(cmd));
=======
using AviatorHandler = Aviator.Application.Planes.Create.Handler;
using CreatePlaneCommand = Aviator.Application.Planes.Create.Command;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<AviatorHandler>();

var app = builder.Build();

app.MapPost("/v1/planes", async (AviatorHandler handler, CreatePlaneCommand cmd)
    => await handler.HandleAsync(cmd));
>>>>>>> 916004cb73b216801d802f3192baac9c9629e6b9

app.Run();
