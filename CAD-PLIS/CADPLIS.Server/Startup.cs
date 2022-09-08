using Autofac;
using Autofac.Configuration;
using Autofac.Extensions.DependencyInjection;
using CADPLIS.Application.Accounts;
using CADPLIS.Application.WorkflowProvider;
using CADPLIS.Common.Accounts;
using CADPLIS.Common.Email;
using CADPLIS.Server.Exceptions;
using CADPLIS.Server.ServiceLocation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OptimaJet.Workflow.Core.Runtime;

namespace CADPLIS.Server
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
            services.AddControllersWithViews(options =>
            {
                //options.Filters.Add(typeof(AuditLogActionFilter));
                options.Filters.Add(typeof(ApiExceptionFilterAttribute));
            });

            services.Configure<EmailAccount>(Configuration.GetSection("EmailAccount"));
            services.Configure<Jwtsetting>(Configuration.GetSection("Jwtsetting"));

            services.AddCadServices(Configuration);
            services.AddScoped<EntityPermissions>();
            services.AddScoped<IEmailSender, MailKitSender>();

            // Create the container builder.
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

            // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<PlisDbcontext>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CADPLIS", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new AutofacModuleRegister());
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CADPLIS"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.AddApplications();
            Runtime = WorkflowInit.Create(new DataServiceProvider(Container));
        }
    }
}
