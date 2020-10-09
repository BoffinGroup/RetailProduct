using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SingleSignServer.Configuration;

namespace SingleSignServer
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityServer()
                .AddInMemoryApiScopes(InMemoryConfig.GetApiScopes())
            .AddInMemoryApiResources(InMemoryConfig.GetApiResources())
           .AddInMemoryIdentityResources(InMemoryConfig.GetIdentityResources())
           .AddTestUsers(InMemoryConfig.GetUsers())
           .AddInMemoryClients(InMemoryConfig.GetClients())
           .AddDeveloperSigningCredential();

            services.AddControllersWithViews();
            services.AddMvc();
        }

      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            

            app.UseStaticFiles();
            app.UseRouting();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
