using Aviator.Application;
using MediatR;
using CreatePlaneCommand = Aviator.Application.Planes.Create.Command;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplication();

var app = builder.Build();

app.MapPost("/v1/planes", async (ISender handler, CreatePlaneCommand cmd)
    => await handler.Send(cmd));

app.Run();
