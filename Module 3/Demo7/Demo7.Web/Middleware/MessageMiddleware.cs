using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Demo7.Web.Middleware
{
    public class MessageMiddleware
    {
        private readonly RequestDelegate _next;

        public MessageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("MessageMiddleware! \r\n");

            //// Getting value from context
            //var qs = context.Request.QueryString;
            //await context.Response.WriteAsync($"Querystring value: {qs.Value} \r\n");

            _next(context); // The same as next.Invoke()
        }
    }
}
