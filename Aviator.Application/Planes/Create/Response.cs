<<<<<<< HEAD
﻿namespace Aviator.Application.Planes.Create
{
    public record Response(string Message);
=======
﻿using Aviator.Application.Shared.Abstractions;

namespace Aviator.Application.Planes.Create
{
    public record Response(string Message) : IResponse;
>>>>>>> 916004cb73b216801d802f3192baac9c9629e6b9
}
