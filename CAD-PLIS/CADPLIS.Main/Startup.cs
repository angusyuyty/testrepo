using Autofac;
using Autofac.Configuration;
using Autofac.Extensions.DependencyInjection;
using Blazored.SessionStorage;
using CADPLIS.Business;
using CADPLIS.Server;
using CADPLIS.Server.services;
using CADPLIS.WebSite;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OptimaJet.Workflow.Core.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CADPLIS.Main
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IContainer Container { get; private set; }
        public WorkflowRuntime Runtime { get; private set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddControllers(options => {
                options.Filters.Add(typeof(AuditLogActionFilter));
            });
            services.AddBlazoredSessionStorage();
            services.AddRazorPages();
            services.AddControllers();
            services.AddOptions();
            services.AddHttpClient();
            services.AddTransient<ApiService>();
            services.AddOptions();
            services.AddAuthorizationCore();
            services.AddDbContext<EFDbcontext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(new Assembly[] { Assembly.Load("CADPLIS.Model") });
            services.AddLogging();

            services.AddScoped<IAuditLogService, DBAuditLogService>();
            //services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

            var builder = new ContainerBuilder();

            builder.Populate(services);

            var config = new ConfigurationBuilder();
            config.AddJsonFile("autofac.json");
            var module = new ConfigurationModule(config.Build());

            builder.RegisterInstance(Configuration);

            builder.RegisterModule(module);

            Container = builder.Build();

            // Create the IServiceProvider based on the container.
            new AutofacServiceProvider(Container);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
