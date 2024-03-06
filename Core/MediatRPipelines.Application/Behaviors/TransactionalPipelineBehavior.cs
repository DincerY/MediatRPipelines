using MediatR;
using System.Data;

namespace MediatRPipelines.Application.Behaviors;

public class TransactionalPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest,TResponse>
where TRequest : class
{
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Console.WriteLine("Transactional");

        //using IDbTransaction transaction = await unitOfWork.BeginTransactionAsync();

        TResponse response = await next();

        //transaction.Commit();

        return response;
    }
}