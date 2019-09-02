using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TestCore1
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync($"{nameof(FirstMiddleware)} In. \r\n");
            await _next(context);
            await context.Response.WriteAsync($"{nameof(FirstMiddleware)} Out. \r\n");
        }
    }
}
