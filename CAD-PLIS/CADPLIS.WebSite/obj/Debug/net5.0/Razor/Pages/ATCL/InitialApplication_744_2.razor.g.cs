#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\ATCL\InitialApplication_744_2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d75014458434edf647436cefe36cf6135cabcc1"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.ATCL
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ATCL/initApplication")]
    public partial class InitialApplication_744_2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<section id=\"initialApplicationSection\"><!DOCTYPE html>\r\n        <html><head><meta charset=\"utf-8\">\r\n                <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, shrink-to-fit=no\">\r\n                <title>Table - Searching Page</title>\r\n                <link rel=\"stylesheet\" href=\"assets/bootstrap/css/bootstrap.min.css\">\r\n                <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\">\r\n                <link rel=\"stylesheet\" href=\"assets/fonts/fontawesome-all.min.css\">\r\n                <link rel=\"stylesheet\" href=\"assets/fonts/font-awesome.min.css\">\r\n                <link rel=\"stylesheet\" href=\"assets/fonts/fontawesome5-overrides.min.css\">\r\n                <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/slim-select/1.27.0/slimselect.min.css\">\r\n                <link rel=\"stylesheet\" href=\"assets/css/untitled-1.css\">\r\n                <link rel=\"stylesheet\" href=\"assets/css/untitled-2.css\">\r\n                <link rel=\"stylesheet\" href=\"assets/css/untitled.css\">\r\n                <style>\r\n                    body {\r\n                        font-family: Arial;\r\n                    }\r\n\r\n                    /* Style the tab */\r\n                    .tab {\r\n                        overflow: hidden;\r\n                        border: 1px solid #ccc;\r\n                        background-color: #f1f1f1;\r\n                    }\r\n\r\n                        /* Style the buttons inside the tab */\r\n                        .tab button {\r\n                            background-color: inherit;\r\n                            float: left;\r\n                            border: none;\r\n                            outline: none;\r\n                            cursor: pointer;\r\n                            padding: 14px 16px;\r\n                            transition: 0.3s;\r\n                            font-size: 17px;\r\n                        }\r\n\r\n                            /* Change background color of buttons on hover */\r\n                            .tab button:hover {\r\n                                background-color: #ddd;\r\n                            }\r\n\r\n                            /* Create an active/current tablink class */\r\n                            .tab button.active {\r\n                                background-color: #ccc;\r\n                            }\r\n\r\n                    /* Style the tab content */\r\n                    .tabcontent {\r\n                        display: none;\r\n                        padding: 6px 12px;\r\n                        border: 1px solid #ccc;\r\n                        border-top: none;\r\n                    }\r\n                </style></head>\r\n\r\n            <body class=\"text-primary\" id=\"page-top\"><div id=\"wrapper\"><div class=\"d-flex flex-column\" id=\"content-wrapper\"><div id=\"content\"><div class=\"container-fluid\"><h3 class=\"text-dark mb-4\"> Initial Application</h3>\r\n                                \r\n                                <div class=\"tab\"><button class=\"tablinks\" onclick=\"location.href=\'/ATCL/initApplication_744_1\'\">DCA 744-1</button>\r\n                                    <button class=\"tablinks\" onclick=\"location.href=\'/ATCL/initApplication_744_2\'\" style=\"background-color: #ccc\">DCA 744-2</button>\r\n                                    <button class=\"tablinks\" onclick=\"location.href=\'/ATCL/initApplication_744_5\'\">DCA 744-5</button></div>\r\n                                \r\n                                <div id=\"London\" class=\"city\" style=\"display:none\"><h2>London</h2>\r\n                                    <p>London is the capital of England.</p></div>\r\n\r\n                                <div id=\"Paris\" class=\"city\" style=\"display:none\"><h2>Paris</h2>\r\n                                    <p>Paris is the capital of France.</p></div>\r\n\r\n                                <div id=\"Tokyo\" class=\"city\" style=\"display:none\"><h2>Tokyo</h2>\r\n                                    <p>Tokyo is the capital of Japan.</p></div>\r\n\r\n                                <div style=\"border-style: groove; border-width:thin\"><div class=\"card shadow mb-3\"><div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold table-header\">Part A: Personal Details</p></div>\r\n                                        <div class=\"card\"><div class=\"card-body\"><div><div class=\"row mb-2\"><div class=\"col-md-3\"><span>License No.:</span></div>\r\n                                                        <div class=\"col\"><span class=\"text-secondary\">Not Assigned Yet</span></div>\r\n                                                        <div class=\"col\"><span>Title:</span></div>\r\n                                                        <div class=\"col\"><span></span><span class=\"text-secondary\">Miss</span></div></div>\r\n                                                    <div class=\"row mb-2\"><div class=\"col\"><span>Surname:</span></div>\r\n                                                        <div class=\"col-md-3\"><span></span><span class=\"text-secondary\">NG</span></div>\r\n                                                        <div class=\"col-md-3\"><span>Forename(s):</span></div>\r\n                                                        <div class=\"col-md-3\"><span></span><span class=\"text-secondary\">Sze Wai</span></div></div>\r\n                                                    <div class=\"row mb-2\"><div class=\"col-md-3\"><span>Date of Birth:</span></div>\r\n                                                        <div class=\"col-md-3\"><span class=\"text-secondary\">04/02/1987<br><br></span></div>\r\n                                                        <div class=\"col-md-3\"><span>Nationality:</span></div>\r\n                                                        <div class=\"col-md-3\"><span></span><span class=\"text-secondary\">CHINESE</span></div></div>\r\n                                                    <div class=\"row\"><div class=\"col-md-3\"><span>Signature of Applicant:&nbsp;</span></div>\r\n                                                        <div class=\"col\"><span><br></span></div></div></div></div></div></div>\r\n                                    <div class=\"card shadow mb-3\"><div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold table-header\">Part B: Class of Rating(s) and Unit Endorsement(s) applied for</p></div>\r\n                                        <div class=\"card\"><div class=\"card-body\"><span class=\"text-secondary\"><strong>(I) Rating</strong> (Please tick one box only)<br><br></span>\r\n                                                <div class=\"row mb-2\"><div class=\"col\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" id=\"formCheck-1\"><label class=\"form-check-label\" for=\"formCheck-1\">Aerodrome Control Rating</label></div></div>\r\n                                                    <div class=\"col\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" id=\"formCheck-1\"><label class=\"form-check-label\" for=\"formCheck-1\">Area Control Surveillance Rating</label></div></div></div>\r\n                                                <div class=\"row mb-4\"><div class=\"col\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" id=\"formCheck-2\"><label class=\"form-check-label\" for=\"formCheck-1\">Approach Control Surveillance Rating</label></div></div>\r\n                                                    <div class=\"col\"><div class=\"form-check\"><input class=\"form-check-input\" type=\"checkbox\" id=\"formCheck-3\"><label class=\"form-check-label\" for=\"formCheck-1\">Others</label></div></div></div>\r\n                                                <div class=\"row mb-3\"><div class=\"col\"><span class=\"text-secondary\"><strong>(II) Rating Endorsement(s)</strong></span></div></div>\r\n                                                <div class=\"row\"><div class=\"col\"><span class=\"text-secondary\"><strong>(II) Limitations</strong></span></div></div></div></div></div>\r\n                                    <div class=\"card shadow mb-3\"><div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold table-header\">Part C:&nbsp;</p></div>\r\n                                        <div class=\"card\"><div class=\"card-body\"><div><input type=\"checkbox\" class=\"checkbox\"><span class=\"text-secondary\">I certify that the above named applicant is in possession of a Hong Kong Class Three Medical Certificate which is valid until 31/08/2025, and confirm that the applicant has successfully completed the SPRAT course on 08/03/2021. I hereby recommend the above application.<br></span></div></div></div></div>\r\n                                    <div class=\"card shadow\"><div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold table-header\">Part D:&nbsp;</p></div>\r\n                                        <div class=\"card\"><div class=\"card-body\"><input type=\"checkbox\" class=\"checkbox\"><span class=\"text-secondary\">The grant of an Air Traffic Control Rating to the above named applicant is approved. This approval entitles the applicant to exercise the privileges of the rating in accordance with the conditions as specified in the ATCO Licence.<br></span></div></div></div></div>\r\n                                <br>\r\n                                <button class=\"btn btn-primary\" type=\"button\"> Submit</button></div></div></div></div></body></html></section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
