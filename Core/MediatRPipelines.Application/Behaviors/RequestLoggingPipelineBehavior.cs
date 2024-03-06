using MediatR;
using Microsoft.Extensions.Logging;

namespace MediatRPipelines.Application.Behaviors;

public class RequestLoggingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest,TResponse>
{
    private readonly ILogger<RequestLoggingPipelineBehavior<TRequest, TResponse>> _logger;

    public RequestLoggingPipelineBehavior(ILogger<RequestLoggingPipelineBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        Console.WriteLine("RequestLogging");

        string requestName = typeof(TRequest).Name;

        _logger.LogInformation($"Processing Request {requestName}");

        TResponse result = await next();

        //if (result.IsSuccess)
        //{

        //}

        _logger.LogInformation($"Completed request {requestName}");

        return result;
    }
}