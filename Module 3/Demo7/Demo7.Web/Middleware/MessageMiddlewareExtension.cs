using Microsoft.AspNetCore.Builder;

namespace Demo7.Web.Middleware
{
    public static class MessageMiddlewareExtension
    {
        public static IApplicationBuilder UseMessage(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MessageMiddleware>();
        }
    }
}
