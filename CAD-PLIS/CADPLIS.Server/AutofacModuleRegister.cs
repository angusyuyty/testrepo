using Autofac;
using CADPLIS.Common.CacheManager;
using CADPLIS.Domain;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using CADPLIS.Server.AuditLog;
using CADPLIS.Server.Controllers;
using CADPLIS.Server.Helper;
using CADPLIS.Server.services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace CADPLIS.Server
{
    public class AutofacModuleRegister : Autofac.Module
    {
        //Override the Autofac pipe Load method to register the injection here
        protected override void Load(ContainerBuilder builder)
        {
            var c = RuntimeHelper.GetAllAssemblies();
            builder.RegisterAssemblyTypes(c.ToArray()).Where(t => t.Name.EndsWith("Repository") && !t.Name.StartsWith("I")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(c.ToArray()).Where(t => t.Name.EndsWith("AppService") && !t.Name.StartsWith("I")).AsImplementedInterfaces();
            builder.RegisterType<DBAuditLogService>().As<IAuditLogService>();
            builder.RegisterType<MemoryCacheService>().As<ICacheService>().SingleInstance();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();
            //Type basetype = typeof(IDependency); //Gets the top-level interface type
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //.Where(t => basetype.IsAssignableFrom(t) && t.IsClass) //Query implementation classes inherited from IDependency. If there is no such statement, register all implementation classes in the current running environment
            //.AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
