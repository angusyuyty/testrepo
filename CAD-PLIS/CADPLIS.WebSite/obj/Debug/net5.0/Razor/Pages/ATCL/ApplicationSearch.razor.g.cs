#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\ATCL\ApplicationSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17715b75c945a32ce0fa5b03c0e2eefb40635d6a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ATCL/applicationList")]
    public partial class ApplicationSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "initialApplicationSection");
            __builder.AddMarkupContent(2, "<!DOCTYPE html>\r\n    ");
            __builder.OpenElement(3, "html");
            __builder.AddMarkupContent(4, @"<head><meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
        <title>Table - Searching Page</title>
        <link rel=""stylesheet"" href=""assets/bootstrap/css/bootstrap.min.css"">
        <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"">
        <link rel=""stylesheet"" href=""assets/fonts/fontawesome-all.min.css"">
        <link rel=""stylesheet"" href=""assets/fonts/font-awesome.min.css"">
        <link rel=""stylesheet"" href=""assets/fonts/fontawesome5-overrides.min.css"">
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slim-select/1.27.0/slimselect.min.css"">
        <link rel=""stylesheet"" href=""assets/css/untitled-1.css"">
        <link rel=""stylesheet"" href=""assets/css/untitled-2.css"">
        <link rel=""stylesheet"" href=""assets/css/untitled.css""></head>

    ");
            __builder.OpenElement(5, "body");
            __builder.AddAttribute(6, "class", "text-primary");
            __builder.AddAttribute(7, "id", "page-top");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "wrapper");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "d-flex flex-column");
            __builder.AddAttribute(12, "id", "content-wrapper");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "content");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container-fluid");
            __builder.AddMarkupContent(17, "<h3 class=\"text-dark mb-4\">Application Search</h3>\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card shadow mb-4");
            __builder.AddMarkupContent(20, "<div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold table-header\">Searching Criteria</p></div>\r\n                            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.OpenElement(25, "div");
            __builder.AddMarkupContent(26, "<div class=\"row mb-2\"><div class=\"col col-md-3\"><span>Name</span></div>\r\n                                            <div class=\"col-md-3\"><input type=\"text\"></div></div>\r\n                                        ");
            __builder.AddMarkupContent(27, "<div class=\"row mb-2\"><div class=\"col col-md-3\"><span>Other Name</span></div>\r\n                                            <div class=\"col-md-3\"><input type=\"text\"></div></div>\r\n                                        ");
            __builder.AddMarkupContent(28, "<div class=\"row mb-2\"><div class=\"col col-md-3\"><span>Licence No.</span></div>\r\n                                            <div class=\"col-md-3\"><input type=\"text\"></div></div>\r\n                                        ");
            __builder.AddMarkupContent(29, @"<div class=""row mb-2""><div class=""col-md-3""><span>Application ID</span></div>
                                            <div class=""col col-md-9""><span class=""text-secondary"">From&nbsp;</span><input type=""text"" class=""input-text1""><span class=""text-secondary"">To</span><input type=""text"" class=""input-text2""></div></div>
                                        ");
            __builder.AddMarkupContent(30, @"<div class=""row mb-2""><div class=""col-md-3""><span>Date of Submission</span></div>
                                            <div class=""col col-md-9""><span class=""text-secondary"">From&nbsp;<input class=""input-text1"" type=""date"">&nbsp;</span><span class=""text-secondary"">To</span><input class=""input-text2"" type=""date""></div></div>
                                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row mb-2");
            __builder.AddMarkupContent(33, "<div class=\"col\"><span>Application Status</span></div>\r\n                                            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-3");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col");
            __builder.OpenElement(38, "select");
            __builder.AddAttribute(39, "id", "ddllic");
            __builder.AddAttribute(40, "multiple");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "value 1");
            __builder.AddContent(43, "Drafted by TU");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                                        ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "value 2");
            __builder.AddContent(47, "Submitted by TU");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                                        ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "value 3");
            __builder.AddContent(51, "Pending by C(TS)");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                                        ");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "value 3");
            __builder.AddContent(55, "Pending by ATMSO");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                                        ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", "value 3");
            __builder.AddContent(59, "Pending by C,ATS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                            <div class=\"col-md-3\"></div>\r\n                                            <div class=\"col-md-3\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row mb-2");
            __builder.AddMarkupContent(64, "<div class=\"col\"><span>Application Type</span></div>\r\n                                            ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-3");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col");
            __builder.OpenElement(69, "select");
            __builder.AddAttribute(70, "id", "apptype");
            __builder.AddAttribute(71, "multiple");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "value 1");
            __builder.AddContent(74, "DCA-744-1,2,5  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                                        ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "value 2");
            __builder.AddContent(78, "DCA-744-2,2A,5  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                                        ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "value 3");
            __builder.AddContent(82, "DCA-744-4,5A,6  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                            <div class=\"col-md-3\"></div>\r\n                                            <div class=\"col-md-3\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                        ");
            __builder.AddMarkupContent(85, "<div class=\"row mb-2\"><div class=\"col\"><button class=\"btn btn-primary\" type=\"button\">Search</button><button class=\"btn btn-primary text-dark bg-light border rounded border-dark mx-3\" type=\"button\">Reset</button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "container-fluid");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "card shadow");
            __builder.AddMarkupContent(91, "<div class=\"card-header py-3\"><p class=\"text-primary m-0 font-weight-bold\">Search Result(s)</p></div>\r\n                        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "card-body");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "row");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col");
            __builder.AddMarkupContent(98, "<span class=\"span-show\">Show</span>");
            __builder.OpenElement(99, "select");
            __builder.AddAttribute(100, "class", "col-md-5");
            __builder.OpenElement(101, "option");
            __builder.AddAttribute(102, "value", "12");
            __builder.AddAttribute(103, "selected");
            __builder.AddContent(104, "10");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                        ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "13");
            __builder.AddContent(108, "15");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                                        ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "14");
            __builder.AddContent(112, "20");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                                    <div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                                ");
            __builder.AddMarkupContent(115, "<div class=\"col col-md-4\"><span class=\"text-dark span-sortby\"><strong>Sort By</strong></span></div>\r\n                                ");
            __builder.AddMarkupContent(116, @"<div class=""col""><div class=""dropdown""><button class=""btn btn-primary dropdown-toggle text-dark bg-light col-md2"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Application ID</button>
                                        <div class=""dropdown-menu""><a class=""dropdown-item"" href=""#"">ID13337211</a><a class=""dropdown-item"" href=""#"">ID13337212<br></a><a class=""dropdown-item"" href=""#"">ID13337213<br></a></div></div></div>
                                ");
            __builder.AddMarkupContent(117, @"<div class=""col""><div class=""dropdown""><button class=""btn btn-primary dropdown-toggle text-dark bg-light col-md-5"" aria-expanded=""false"" data-toggle=""dropdown"" type=""button"">Ascending</button>
                                        <div class=""dropdown-menu""><a class=""dropdown-item"" href=""#"">Ascending</a><a class=""dropdown-item"" href=""#"">Descending<br></a></div></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                            ");
            __builder.AddMarkupContent(119, "<div class=\"row\"><div class=\"col-md-6 text-nowrap\"><div id=\"dataTable_length\" class=\"dataTables_length\" aria-controls=\"dataTable\"></div></div></div>\r\n                            ");
            __builder.AddMarkupContent(120, "<div class=\"table-responsive table mt-2\" id=\"dataTable-1\" role=\"grid\" aria-describedby=\"dataTable_info\"><table class=\"table my-0\" id=\"dataTable\"><thead><tr><th>Application ID</th>\r\n                                            <th>Date of Submission</th>\r\n                                            <th>Type</th>\r\n                                            <th>Status</th>\r\n                                            <th>Last Updated By</th></tr></thead>\r\n                                    <tbody><tr><td><a href=\"ATCL/initApplication?application_no=13337211\">13337211 </a></td>\r\n                                            <td>02/02/2021</td>\r\n                                            <td>DCA-744-1,2,5</td>\r\n                                            <td>Pending by ATMSO</td>\r\n                                            <td>Joe AU<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337212\">13337212 </a></td>\r\n                                            <td>15/03/2021</td>\r\n                                            <td>DCA-744-2,2A,5<br></td>\r\n                                            <td>Drafted by TU</td>\r\n                                            <td>Ben NG<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337213\">13337213 </a></td>\r\n                                            <td>18/03/2021</td>\r\n                                            <td>DCA-744-4,5A,6<br></td>\r\n                                            <td>Submitted by TU<br></td>\r\n                                            <td>Ben NG<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337214\">13337214 </a></td>\r\n                                            <td>20/02/2021</td>\r\n                                            <td>DCA-744-4,5A,6<br></td>\r\n                                            <td>Pending by C,ATS<br></td>\r\n                                            <td>Peter HO<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337215\">13337215 </a></td>\r\n                                            <td>08/03/2021</td>\r\n                                            <td>DCA-744-4,5A,6<br></td>\r\n                                            <td>Pending by C,ATS</td>\r\n                                            <td>Peter HO<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337216\">13337216 </a></td>\r\n                                            <td>31/03/2021</td>\r\n                                            <td>DCA-744-2,2A,5<br></td>\r\n                                            <td>Drafted by TU</td>\r\n                                            <td>Matt LI<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337217\">13337217 </a></td>\r\n                                            <td>03/03/2021</td>\r\n                                            <td>DCA-744-1,2,5<br></td>\r\n                                            <td>Pending by ATMSO<br></td>\r\n                                            <td>Joe AU<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337218\">13337218 </a></td>\r\n                                            <td>18/02/2021</td>\r\n                                            <td>DCA-744-1,2,5<br></td>\r\n                                            <td>Pending by C(TS)</td>\r\n                                            <td>Ada LI<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337219\">13337219 </a></td>\r\n                                            <td>17/01/2021</td>\r\n                                            <td>DCA-744-4,5A,6<br></td>\r\n                                            <td>Pending by C(TS)</td>\r\n                                            <td>Bowie HO<br></td></tr>\r\n                                        <tr><td><a href=\"ATCL/initApplication?application_no=13337220\">13337220 </a></td>\r\n                                            <td>18/03/2021</td>\r\n                                            <td>DCA-744-4,5A,6<br></td>\r\n                                            <td>Submitted by TU</td>\r\n                                            <td>Ben NG<br></td></tr></tbody>\r\n                                    <tfoot><tr></tr></tfoot></table></div>\r\n                            ");
            __builder.AddMarkupContent(121, @"<div class=""row""><div class=""col-md-6 align-self-center""><p id=""dataTable_info"" class=""dataTables_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 27</p></div>
                                <div class=""col-md-6""><nav class=""d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers""><ul class=""pagination""><li class=""page-item disabled""><a class=""page-link"" href=""#"" aria-label=""Previous""><span aria-hidden=""true"">«</span></a></li>
                                            <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                            <li class=""page-item""><a class=""page-link"" href=""#"" aria-label=""Next""><span aria-hidden=""true"">»</span></a></li></ul></nav></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                ");
            __builder.AddMarkupContent(123, "<footer class=\"bg-white sticky-footer\"><div class=\"container my-auto\"><div class=\"text-center my-auto copyright\"><span class=\"text-secondary\">Copyright © ASL 2021</span></div></div></footer>");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "<a class=\"border rounded d-inline scroll-to-top\" href=\"#page-top\"><i class=\"fas fa-angle-up\"></i></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
