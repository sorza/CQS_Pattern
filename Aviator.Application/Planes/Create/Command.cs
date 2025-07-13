using MediatR;

namespace Aviator.Application.Planes.Create
{
    public record Command(string Name) : IRequest<Response>;    
}
