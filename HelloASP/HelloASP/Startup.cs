using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // this method is for (1) configuring middleware before actually plugging it in.
            // adding services to the DI containter. (more on that eventually
            services.AddControllers();
        }

        private static void HandleMapTest1(IApplicationBuilder app)
        {

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 1");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseRouting();

            app.Map("/map1", HandleMapTest1);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate. <p>");
            });
        }

    }
}
