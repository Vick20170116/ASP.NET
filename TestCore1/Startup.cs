using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace TestCore1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDiSample, DiSample>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<FirstMiddleware>();

            //// Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("First Middleware In. \r\n");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("First Middleware Out. \r\n");
            //});

            //// 不同URL
            //app.Map("/second", mapApp =>
            //{
            //    mapApp.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync("Second Middleware In. \r\n");
            //        await next.Invoke();
            //        await context.Response.WriteAsync("Second Middleware Out. \r\n");
            //    });

            //    mapApp.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("Second. \r\n");
            //    });

            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Third Middleware In. \r\n");
            //    await next.Invoke();
            //    await context.Response.WriteAsync("Third Middleware Out. \r\n");
            //});


            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World! \r\n");
            });
        }
    }
}
