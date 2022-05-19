using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using MovieCentral.Application.Exceptions;

namespace MovieCentral.Server.Filters;

public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    private readonly ILogger<ApiExceptionFilterAttribute> _logger;

    public ApiExceptionFilterAttribute(ILogger<ApiExceptionFilterAttribute> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public override void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case NotFoundException:
                HandleNotFoundException(context);
                break;
            case DbUpdateException:
                HandleEntityFrameworkException(context);
                break;
            case UnauthorizedException:
                HandleUnauthorizedException(context);
                break;
            case OperationCanceledException:
                HandleOperationCancelledException(context);
                break;
            default:
                HandleUnknownException(context);
                break;
        }

        base.OnException(context);
    }

    private void HandleOperationCancelledException(ExceptionContext context)
    {
        _logger.LogWarning("Request was cancelled.");
        // Alternativly we can use Client Closed Request (499)
        context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
        context.ExceptionHandled = true;
    }

    private void HandleUnauthorizedException(ExceptionContext context)
    {
        _logger.LogWarning("Unauthorized access to resource attempted. {ExceptionMessage}", context.Exception.Message);

        context.Result = new UnauthorizedResult();
        context.ExceptionHandled = true;
    }

    private void HandleEntityFrameworkException(ExceptionContext context)
    {
        _logger.LogError("Entityframework Error, Type: {exception} Message: {message}", context.Exception.GetType().Name, context.Exception.Message);

        var details = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = "An error occurred while processing your request.",
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
            Detail = "Unknown database error."
        };

        context.Result = new ObjectResult(details)
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }

    private void HandleUnknownException(ExceptionContext context)
    {
        _logger.LogError("Unknown Exception, Type: {exception} Message: {message}", context.Exception.GetType().Name, context.Exception.Message);

        var details = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = "An error occurred while processing your request.",
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
        };

        context.Result = new ObjectResult(details)
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }

    private void HandleNotFoundException(ExceptionContext context)
    {
        _logger.LogWarning("Resource not found. {ExceptionMessage}", context.Exception.Message);

        var details = new ProblemDetails()
        {
            Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
            Title = "The specified resource was not found.",
        };

        context.Result = new NotFoundObjectResult(details);
        context.ExceptionHandled = true;
    }
}
