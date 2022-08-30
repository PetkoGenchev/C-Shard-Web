using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ASP.NETMVCDemoMiddleWare.Services
{    public class CustomMiddleware
    {
        private readonly RequestDelegate next;

        public CustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            if (httpContext.Request.Query.ContainsKey("SomeKey"))
            {
                httpContext.Response.Headers.Add("Custom-Header", "Value");
            }

            await this.next(httpContext);
        }
    }
}
