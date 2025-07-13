using Aviator.Application.Shared.Abstractions;

namespace Aviator.Application.Planes.Create
{
    public record Command(string Name) : ICommand;    
}
