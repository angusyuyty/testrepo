using AutoMapper.Configuration;
using Blazored.SessionStorage;
using CADPLIS.Application;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CADPLIS.Server
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCadServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddRazorPages();
            services.AddMediatR(typeof(Startup).Assembly);
            services.AddDbContext<PlisDbcontext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddLogging();
            services.AddMemoryCache();
            services.AddAuthorizationCore();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration.GetValue<string>("Jwtsetting:Issuer"),
                    ValidAudience = configuration.GetValue<string>("Jwtsetting:Audience"),
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("Jwtsetting:Key"))),
                    RequireExpirationTime = true
                };
            });
            return services;
        }
    }
}
