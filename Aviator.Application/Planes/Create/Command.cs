<<<<<<< HEAD
﻿using MediatR;

namespace Aviator.Application.Planes.Create
{
    public record Command(string Name) : IRequest<Response>;    
=======
﻿using Aviator.Application.Shared.Abstractions;

namespace Aviator.Application.Planes.Create
{
    public record Command(string Name) : ICommand;    
>>>>>>> 916004cb73b216801d802f3192baac9c9629e6b9
}
