using Aviator.Application.Shared.Abstractions;

namespace Aviator.Application.Planes.Create
{
    public class Handler : IHandler<Command, Response>
    {
        public async Task<Response> HandleAsync(Command command)
        {
            await Task.Delay(10);
            return new Response($"Plane {command.Name} created successfully.");
        }
    }
}
