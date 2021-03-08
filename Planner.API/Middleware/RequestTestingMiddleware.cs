using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Planner.API.Middleware
{
    /// <summary>
    /// Testing middleware implementation.
    /// </summary>
    public class RequestTestingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTestingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke the middleware.
        /// </summary>
        /// <param name="context">HttpContext.</param>
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Invoking middleware");

            await _next(context);
        }
    }
}
