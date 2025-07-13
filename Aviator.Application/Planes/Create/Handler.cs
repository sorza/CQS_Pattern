using MediatR;

namespace Aviator.Application.Planes.Create
{
    public class Handler : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken = default)
        {
            await Task.Delay(10);
            return new Response($"Plane {request.Name} created successfully.");
        }        
    }
}
