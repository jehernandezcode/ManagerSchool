using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Domain.Common;
using SchoolManager.Commons;
using SchoolManagement.Application.Exceptions;
using ManagerSchool.Exceptions;

namespace SchoolManager.Filters
{
    public class GlobalExceptionsFilter : IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionsFilter> _logger;

        public GlobalExceptionsFilter(ILogger<GlobalExceptionsFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            _logger.LogError(exception, "Error Description");

            if (exception.GetType() == typeof(BadRequestException))
            {
                var validation = new
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Bad Request",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    Error = new[] { validation }
                };

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                
            }
            else if (exception.GetType() == typeof(UnAuthorizationException))
            {
                var validation = new
                {
                    Status = StatusCodes.Status403Forbidden,
                    Title = "Forbidden",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.Forbidden,
                    Error = new[] { validation }
                };

                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            }
            else if (exception.GetType() == typeof(DomainException))
            {
                var validation = new
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "DomainError",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    Error = new[] { validation }
                };

                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (exception.GetType() == typeof(UnAuthenticationException))
            {
                var validation = new
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Title = "UnAuthorized",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.Unauthorized,
                    Error = new[] { validation }
                };

                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else if (exception.GetType() == typeof(NotFoundException))
            {
                var validation = new
                {
                    Status = StatusCodes.Status404NotFound,
                    Title = "Not found",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.NotFound,
                    Error = new[] { validation }
                };

                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            }
            else
            {
                var validation = new
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Internal Error",
                    Detail = exception.Message
                };

                var json = new ApiResponse
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.InternalServerError,
                    Error = new[] { validation }
                };

                context.Result = new ObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            context.ExceptionHandled = true;
        }
    }
}
