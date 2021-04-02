using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Mime;
using Bakery.RazorPages.Admin.Services;

namespace Bakery.RazorPages.Admin
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
            services.AddRazorPages();

            services.AddHttpClient<ProductService>(config => {
                config.BaseAddress = new Uri(Configuration["ProductService:BaseAddress"]);
                config.DefaultRequestHeaders.Add("Accept", MediaTypeNames.Application.Json);
            });

            services.AddHttpClient<OrderService>(config => {
                config.BaseAddress = new Uri(Configuration["OrderService:BaseAddress"]);
                config.DefaultRequestHeaders.Add("Accept", MediaTypeNames.Application.Json);
            });

            services.AddHttpClient<InvoiceService>(config => {
                config.BaseAddress = new Uri(Configuration["InvoiceService:BaseAddress"]);
                config.DefaultRequestHeaders.Add("Accept", MediaTypeNames.Application.Json);
            });

            services.AddAntiforgery(options => options.HeaderName = "X-CSRF-TOKEN");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
