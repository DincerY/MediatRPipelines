using MediatR;

namespace MediatRPipelines.Application.Behaviors;

public class ExceptionHandlingPipelineBehavior<TRequest, TResponse> : 
    IPipelineBehavior<TRequest, TResponse> where TRequest : class
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Console.WriteLine("ExceptionHandling");
        try
        {
            return await next();
        }
        catch (Exception exception)
        {
            throw;
        }
    }
}