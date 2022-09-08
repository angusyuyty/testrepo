using CADPLIS.Common.File;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NLog.Web.AspNetCore;
using NLog.Web;
using Autofac.Extensions.DependencyInjection;

namespace CADPLIS.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");
                    var config = builder.Build();
                    var uncName = config["NetWorkFile:FilePath"];

                    //FileServerConnection fileServerConnection = new FileServerConnection(uncName,
                    //    config["NetWorkFile:UserName"], config["NetWorkFile:PassWord"]);
                    //fileServerConnection.Disconnect();
                    //fileServerConnection.Connect();
                    webBuilder.UseStartup<Startup>();
                }).ConfigureLogging((logging)=> {
                    logging.ClearProviders();
                }).UseNLog();
    }
}
