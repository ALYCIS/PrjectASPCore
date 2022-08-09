using PrjectASPCore.Models;
using PrjectASPCore.Repository.Books;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //ASP.NET Core est une app console qui contient la fonction main, dans la fonction Main, l'hôte est en cours d'installation
        // La configuration du web server s'appelle Kestral, Par défaut l'application ASP.NET est hébergé sur son propre serveur web.
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"))
                );
            /*services.AddDbContext<AppDbContext>(opt =>
            {
                opt.EnableSensitiveDataLogging();
            });*/
            // On configurer les services qu'on a besoins
            services.AddControllersWithViews(); // ou services.AddMvc();
            services.AddScoped<IBookRepository, MookBookRepository>();
            services.AddScoped<ICategoryBookRepository, MookCategoryBookRepository>();
            /*services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryBookRepository, CategoryBookRepository>();*/

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // C'est ici qu'on va utiliser les Middleware de notre application.(pipeline)
            // Pour acceder aux fichiers statics, il faut utiliser le middleware useStatic
            if (env.IsDevelopment()) // Si on est en mode dev, pour afficher les exeception
            {
                app.UseDeveloperExceptionPage();//1
            }

            //Le premier middleware, l'ordre est très important
            app.UseHttpsRedirection(); //2,
            app.UseStaticFiles(); //3, nous permet d'utiliser : css, javascript

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Test}/{action=Index}/{id?}"
                    );
                /* endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 });*/
            });
        }
    }
}