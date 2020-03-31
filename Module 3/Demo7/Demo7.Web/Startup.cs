using Demo7.Web.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo7.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        //// 1. First run with one middleware
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    //This middleware runs and that's all
        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync("Hey there");
        //    });
        //}

        //// 2. Second run with two middlewares
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    var sb = new StringBuilder();
        //    sb.Append("Welcome!");
        //    sb.Append(" ");

        //    // This middleware runs and invokes the next work
        //    app.Use(async (context, next) =>
        //    {
        //        sb.Append("I am a middleware!");
        //        sb.Append(" ");

        //        await next.Invoke();

        //        // We can do some action here that doesn't change the Response: Logging, for example
        //    });

        //    app.Run(async context =>
        //    {
        //        await context.Response.WriteAsync(sb.ToString());
        //    });
        //}

        //// 3. Extract middleware to different files and run
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //// Create an extension to use this type of call
            //app.UseMessage();

            app.UseMiddleware<MessageMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
