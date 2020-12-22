using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Servicio_Lista_Numero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Servicio_Lista_Numero.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlerMiddleware> _logger;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
           
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Una expcepcion ocurrio:{ex}");
                await ErrorEncontrado(httpContext,ex);
               
            }
        }
        public Task ErrorEncontrado(HttpContext context , Exception exception)
        {
            context.Response.ContentType = "appliacation/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(new ErrorHandler()
            {
                StatusCode=context.Response.StatusCode,
                Message="miau"
            }.ToString());
        }

        //public async Task Invoke(HttpContext httpContext)
        //{
        //    //httpContext.Items["prueba"] = "2020";
        //    await _next.Invoke(httpContext);
        //    if (httpContext.Response.StatusCode >= 400 || httpContext.Response.StatusCode < 500)
        //    {
        //        _logger.LogInformation("Error con el cliente");
        //    }
        //    if (httpContext.Response.StatusCode >= 500 || httpContext.Response.StatusCode < 600)
        //    {
        //        _logger.LogInformation("Error con el servidor");
        //    }
        //}

    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ErrorHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
