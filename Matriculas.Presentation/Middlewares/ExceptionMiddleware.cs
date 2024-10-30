using Matriculas.Application.Exceptions;
using Matriculas.Presentation.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace Matriculas.Presentation.Middlewares
{
    internal class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _hostEnvironment;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment hostEnvironment)
        {
            _next = next;
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Application Error Exception: {ErrorMessage}", e.Message);
                httpContext.Response.ContentType = "application/json";
                int statusCode = (int)HttpStatusCode.InternalServerError;
                string? result = null;

                switch (e)
                {
                    case NotFoundException notFoundException:
                        statusCode = (int)HttpStatusCode.NotFound;
                        result = notFoundException.Message;
                        break;
                    case BadRequestException badRequestException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        result = badRequestException.Message;
                        break;
                    default:
                        break;
                }

                if (string.IsNullOrWhiteSpace(result))
                {
                    dynamic response;

                    if (_hostEnvironment.IsDevelopment())
                    {
                        response = new CodeError(statusCode, e.Message, e.StackTrace);
                    }
                    else
                    {
                        response = new CodeErrorResponse(statusCode, e.Message);
                    }

                    var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                    result = JsonSerializer.Serialize(response, options);
                }

                httpContext.Response.StatusCode = statusCode;

                await httpContext.Response.WriteAsync(result);
            }
        }
    }
}
