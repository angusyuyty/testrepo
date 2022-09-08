using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common.Email
{
    public class EmailAccount
    {
        public string Host { get; set; }

        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        //static EmailAccount()
        //{
        //    var builder = new ConfigurationBuilder()
        //                 .SetBasePath(Directory.GetCurrentDirectory())
        //                 .AddJsonFile("appsettings.json");
        //    var config = builder.Build();
        //    Host = config["EmailSend:Host"];
        //    Port = Convert.ToInt32(config["EmailSend:Port"]);
        //    EnableSsl = bool.Parse(config["EmailSend:EnableSsl"]);
        //    UserName= config["EmailSend:UserName"];
        //    Password= config["EmailSend:Password"];
        //}
    }
}
