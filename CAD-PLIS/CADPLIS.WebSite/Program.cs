using Blazored.LocalStorage;
using Blazored.SessionStorage;
using BlazorStrap;
using CADPLIS.WebSite.Auth;
using CADPLIS.WebSite.Extension;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Notice;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;


namespace CADPLIS.WebSite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            }.EnableIntercept(sp)); // <- Add this!
            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddMatBlazor();
            builder.Services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
                //config.RequireInteraction = true;
            });
            builder.Services.AddLogging();
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            // BlazorStrap
            builder.Services.AddBootstrapCss();

            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>()
                .AddScoped<IAuthService, AuthService>();
            builder.Services.AddScoped<IViewNotifier, ViewNotifier>();
            builder.Services.AddScoped<HttpRepository>();
            builder.Services.AddScoped<HttpInterceptorService>();
            await builder.Build().RunAsync();
        }
    }
}
