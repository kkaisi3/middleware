
using Microsoft.AspNetCore.Identity.Data;

namespace Adventure.Middleware
{
    public class LoggerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Starting Middleware");

            LogRequest(context);
            await next.Invoke(context);
            LogResponse(context);


            Console.WriteLine("Ending Middleware");
        }

        private async Task LogRequest(HttpContext context)
        {
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var method = context.Request.Method;
            var path = context.Request.Path;

            var request = $"Request: {time}: {method} {path}";
            File.AppendAllText("ServerLogs.txt", request);

        }
        private async Task LogResponse(HttpContext context)
        {
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var method = context.Request.Method;
            var path = context.Request.Path;

            var request = $"\nRequest: {time}: {method} {path}";
            File.AppendAllText("ServerLogs.txt", request);

        }
    }
}
