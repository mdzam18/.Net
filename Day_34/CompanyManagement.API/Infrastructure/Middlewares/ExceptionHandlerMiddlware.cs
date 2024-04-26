using Newtonsoft.Json;

namespace CompanyManagement.API.Infrastructure.Middlewares
{
    public class ExceptionHandlerMiddlware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddlware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);

            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            await LogException(ex);

            var error = new ApiError(context, ex);
            var result = JsonConvert.SerializeObject(error);

            context.Response.Clear();
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.Status.Value;

            await context.Response.WriteAsync(result);
        }

        private async Task LogException(Exception ex)
        {
            var toLog = ex.Message;

            await File.AppendAllTextAsync("Exceptions.txt", toLog);
        }
    }
}