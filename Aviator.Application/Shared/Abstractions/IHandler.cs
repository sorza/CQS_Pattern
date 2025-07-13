namespace Aviator.Application.Shared.Abstractions
{
    public interface IHandler<TCommand, TResponse>
        where TCommand : ICommand
        where TResponse : IResponse   
    {
        Task<TResponse> HandleAsync(TCommand command);
    }    
}
