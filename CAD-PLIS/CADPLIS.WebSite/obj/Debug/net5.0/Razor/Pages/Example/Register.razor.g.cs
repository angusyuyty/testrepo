#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Example\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ba00ce7ff3355f7cb0d5c6844373024376e4c1e"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.Example
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap.Extensions.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain.MCApplications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.HttpClients;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n");
            __builder.AddMarkupContent(1, "<body class=\"bg-primary\"><div id=\"layoutAuthentication\"><div id=\"layoutAuthentication_content\"><main><div class=\"container\"><div class=\"row justify-content-center\"><div class=\"col-lg-7\"><div class=\"card shadow-lg border-0 rounded-lg mt-5\"><div class=\"card-header\"><h3 class=\"text-center font-weight-light my-4\">Create Account</h3></div>\r\n                                <div class=\"card-body\"><form><div class=\"row mb-3\"><div class=\"col-md-6\"><div class=\"form-floating mb-3 mb-md-0\"><input class=\"form-control\" id=\"inputFirstName\" type=\"text\" placeholder=\"Enter your first name\">\r\n                                                    <label for=\"inputFirstName\">First name</label></div></div>\r\n                                            <div class=\"col-md-6\"><div class=\"form-floating\"><input class=\"form-control\" id=\"inputLastName\" type=\"text\" placeholder=\"Enter your last name\">\r\n                                                    <label for=\"inputLastName\">Last name</label></div></div></div>\r\n                                        <div class=\"form-floating mb-3\"><input class=\"form-control\" id=\"inputEmail\" type=\"email\" placeholder=\"name@example.com\">\r\n                                            <label for=\"inputEmail\">Email address</label></div>\r\n                                        <div class=\"row mb-3\"><div class=\"col-md-6\"><div class=\"form-floating mb-3 mb-md-0\"><input class=\"form-control\" id=\"inputPassword\" type=\"password\" placeholder=\"Create a password\">\r\n                                                    <label for=\"inputPassword\">Password</label></div></div>\r\n                                            <div class=\"col-md-6\"><div class=\"form-floating mb-3 mb-md-0\"><input class=\"form-control\" id=\"inputPasswordConfirm\" type=\"password\" placeholder=\"Confirm password\">\r\n                                                    <label for=\"inputPasswordConfirm\">Confirm Password</label></div></div></div>\r\n                                        <div class=\"mt-4 mb-0\"><div class=\"d-grid\"><a class=\"btn btn-primary btn-block\" href=\"login.html\">Create Account</a></div></div></form></div>\r\n                                <div class=\"card-footer text-center py-3\"><div class=\"small\"><a href=\"login.html\">Have an account? Go to login</a></div></div></div></div></div></div></main></div>\r\n        <div id=\"layoutAuthentication_footer\"><footer class=\"py-4 bg-light mt-auto\"><div class=\"container-fluid px-4\"><div class=\"d-flex align-items-center justify-content-between small\"><div class=\"text-muted\">Copyright &copy; Your Website 2021</div>\r\n                        <div><a href=\"#\">Privacy Policy</a>\r\n                            &middot;\r\n                            <a href=\"#\">Terms &amp; Conditions</a></div></div></div></footer></div></div></body>\r\n<link href=\"css/bootstrap/styles.css\" rel=\"stylesheet\">");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
