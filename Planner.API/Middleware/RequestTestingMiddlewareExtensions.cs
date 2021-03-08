using Microsoft.AspNetCore.Builder;

namespace Planner.API.Middleware
{
    /// <summary>
    /// Extension method for RequestTestingMiddleware.
    /// </summary>
    public static class RequestTestingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestTestingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTestingMiddleware>();
        }
    }
}
