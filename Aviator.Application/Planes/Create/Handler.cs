<<<<<<< HEAD
﻿using MediatR;

namespace Aviator.Application.Planes.Create
{
    public class Handler : IRequestHandler<Command, Response>
    {
        public async Task<Response> Handle(Command request, CancellationToken cancellationToken = default)
        {
            await Task.Delay(10);
            return new Response($"Plane {request.Name} created successfully.");
        }        
=======
﻿using Aviator.Application.Shared.Abstractions;

namespace Aviator.Application.Planes.Create
{
    public class Handler : IHandler<Command, Response>
    {
        public async Task<Response> HandleAsync(Command command)
        {
            await Task.Delay(10);
            return new Response($"Plane {command.Name} created successfully.");
        }
>>>>>>> 916004cb73b216801d802f3192baac9c9629e6b9
    }
}
