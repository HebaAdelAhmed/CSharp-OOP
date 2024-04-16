using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Structure
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<EmployeeService>();
            services.AddControllersWithViews(); // Add MVC Serives
            //services.AddRazorPages(); // Razor Pages
            //services.AddControllers(); // Web APIs
            //services.AddMvc(); // MVC && Razor Pages && Web APIs
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Middelware - Pipeline
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/Route", async context =>
                {
                    await context.Response.WriteAsync("Hello Route!");
                });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Movies}/{action=GetMovie}/{id:int?}", // U Can Send Id In URL Or NOT and Must Be Int
                    defaults: new { action = "GetMovie" }
                    );
            });
        }
    }
}
