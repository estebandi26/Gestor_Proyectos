﻿//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Linq;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;


//namespace Gestor_Proyectos.API
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            configuration = configuration;
//        }
//        public IConfiguration Configuration { get; }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllersWithViews();
//        }
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("Home/Error");
//                app.UseHsts();
//            }
//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllerRoute(
//                    name: "default",
//                    pattern: "{controller=Home}/{action=Index}/{id?}");
//            });
//        }
//    }
//}
