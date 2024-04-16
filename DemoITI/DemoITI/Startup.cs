using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DemoITI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // "Set of middelwares components"
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            #region InLine Middelwares
            //// Inline Middelware => Anynoms Function


            //app.Use(async (context, next) =>
            //{ // Execute then Call the next
            //    // Can add response or not
            //    await context.Response.WriteAsync("Middelware 1.1 \n");
            //    await next.Invoke();
            //    // Can call the next middelware or not "Short circle"
            //    await context.Response.WriteAsync("Middelware 1.2\n");

            //});
            //app.Use(async (context, next) =>
            //{ // Execute then Call the next
            //    // Can add response or not
            //    await context.Response.WriteAsync("Middelware 2.1\n");
            //    await next.Invoke();
            //    // Can call the next middelware or not "Short circle"
            //    await context.Response.WriteAsync("Middelware 2.2\n");

            //});

            //app.Run(async (context) =>
            //{ // Will terminate
            //    await context.Response.WriteAsync("Middelware 3 => Terminate\n");
            //    //
            //});

            //app.Use(async (context, next) =>
            //{ // Execute then Call the next =>>> UnReachable
            //    // Can add response or not
            //    await context.Response.WriteAsync("Middelware 3\n");
            //    await next.Invoke();
            //    // Can call the next middelware or not "Short circle"
            //}); 
            #endregion
            #region Middelware Component

            // Build in => Middelware Components

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            #endregion
        }
    }
}
