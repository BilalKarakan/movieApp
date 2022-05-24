using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieApp.web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // localhost:5000
            // localhost:5000/movies
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}"
                );

                // localhost:5000
                //endpoints.MapControllerRoute(
                  //  name: "home",
                  //  pattern: "",
                  //  defaults: new { controller = "Home", action = "index" }
                //);

                // localhost:5000/about
                //endpoints.MapControllerRoute(
                  //  name: "about",
                  //  pattern: "hakkimizda",
                  //  defaults: new { controller = "Home", action = "About" }
                //);

                // localhost:5000/movies/list
                //endpoints.MapControllerRoute(
                  //  name: "movieList",
                  //  pattern: "movies/list",
                  //  defaults: new { controller = "Movies", action = "List" }
                //);

                // localhost:5000/movies/details
                //endpoints.MapControllerRoute(
                  //  name: "movieDetails",
                  //  pattern: "movies/details",
                  //  defaults: new { controller = "Movies", action = "Details" }
                //);
            });
        }
    }
}
