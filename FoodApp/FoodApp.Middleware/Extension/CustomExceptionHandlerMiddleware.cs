using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.Json;

namespace FoodApp.Middleware.Extension
{
    public static class CustomExceptionHandlerMiddleware
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder app, bool isDevelopmentEnvironment, ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger(typeof(CustomExceptionHandlerMiddleware));
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var errorMessage = $"{contextFeature.Error}";
                        var statusCode = (int)HttpStatusCode.InternalServerError;

                        logger.LogError(errorMessage);

                        var responseMessage = "Internal Server Error";
                        if (isDevelopmentEnvironment)
                        {
                            responseMessage = errorMessage;
                        }

                        context.Response.StatusCode = statusCode;
                        context.Response.ContentType = "application/json";
                        context.Response.WriteAsync(JsonSerializer.Serialize(new
                        {
                            ErrorCode = statusCode,
                            ErrorMessage = responseMessage
                        }, new JsonSerializerOptions() { WriteIndented = true }).ToString());
                    }
                });
            });
        }
    }
}
