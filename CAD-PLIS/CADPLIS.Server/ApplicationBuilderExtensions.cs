using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddApplications(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
                //defaults: new { controller = "Designer", action = "Index" });
                endpoints.MapFallbackToFile("index.html");
            });
            return app;
        }
    }
}
