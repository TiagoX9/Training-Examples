using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo1.Web
{
    public class Startup
    {
        // Add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // 1. Add services
            services.AddControllersWithViews();
        }

        // Configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // 2. Add middlewares
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // 3. Add proper routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello Buhler!");
                //});
            });
        }
    }
}
