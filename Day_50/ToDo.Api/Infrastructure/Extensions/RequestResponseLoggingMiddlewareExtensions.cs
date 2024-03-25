using ToDo.Api.Middlewares;

namespace ToDo.Api.Infrastructure.Extensions
{
    public static class RequestResponseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<RequestResponseLoggin>();

            return builder;
        }
    }
}
