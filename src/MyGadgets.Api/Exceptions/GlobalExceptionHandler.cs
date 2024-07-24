using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using MyGadgets.Domain.Exceptions;
using System.Net;

namespace MyGadgets.Api.Exceptions;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception ex, CancellationToken cancellationToken)
    {
        HttpStatusCode statusCode = ex switch
        {
            _ when ex is EntityNotFoundException => HttpStatusCode.NotFound,
            _ => HttpStatusCode.InternalServerError,
        };

        var problemDetails = new ValidationProblemDetails
        {
            Status = (int)statusCode,
            Title = statusCode.GetDisplayName(),
            Detail = ex.Message,
            Type = ex.GetType().Name,
        };

        httpContext.Response.StatusCode = (int)statusCode;
        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}

