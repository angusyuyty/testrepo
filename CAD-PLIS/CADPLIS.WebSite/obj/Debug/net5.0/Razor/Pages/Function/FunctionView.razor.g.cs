#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49a2d313a055b13012ea36f4128f2f2de6cabe5"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.Function
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Function/View/{Id:int}")]
    public partial class FunctionView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h3>Function Detail</h3>\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "mat-layout-grid mat-layout-grid-align-left");
            __builder.AddAttribute(4, "style", "max-width: 800px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(7, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Function ID</label></div>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mat-layout-grid-cell");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "label");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.FunctionId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(16, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Function Type</label></div>\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mat-layout-grid-cell");
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "class", "label");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.FunctionType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(25, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Function Name</label></div>\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "mat-layout-grid-cell");
            __builder.OpenElement(28, "label");
            __builder.AddAttribute(29, "class", "label");
            __builder.AddContent(30, 
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.FunctionDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(34, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Display Sequence No</label></div>\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "mat-layout-grid-cell");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "class", "label");
            __builder.AddContent(39, 
#nullable restore
#line 34 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.DisplaySequence

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(43, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Is System Function</label></div>\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "mat-layout-grid-cell");
            __builder.OpenElement(46, "label");
            __builder.AddAttribute(47, "class", "label");
            __builder.AddContent(48, 
#nullable restore
#line 42 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.SystemFunction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(52, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created By</label></div>\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "mat-layout-grid-cell");
            __builder.OpenElement(55, "label");
            __builder.AddAttribute(56, "class", "label");
            __builder.AddContent(57, 
#nullable restore
#line 51 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.CreatedBy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(61, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created User Role</label></div>\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "mat-layout-grid-cell");
            __builder.OpenElement(64, "label");
            __builder.AddAttribute(65, "class", "label");
            __builder.AddContent(66, 
#nullable restore
#line 59 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.CreatedUserRoleId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(70, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created date</label></div>\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "mat-layout-grid-cell");
            __builder.OpenElement(73, "label");
            __builder.AddAttribute(74, "class", "label");
            __builder.AddContent(75, 
#nullable restore
#line 67 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(79, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated By </label></div>\r\n            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "mat-layout-grid-cell");
            __builder.OpenElement(82, "label");
            __builder.AddAttribute(83, "class", "label");
            __builder.AddContent(84, 
#nullable restore
#line 75 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.UpdatedBy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(88, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated User Role </label></div>\r\n            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "mat-layout-grid-cell");
            __builder.OpenElement(91, "label");
            __builder.AddAttribute(92, "class", "label");
            __builder.AddContent(93, 
#nullable restore
#line 83 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.UpdatedUserRoleId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(97, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated date </label></div>\r\n            ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "mat-layout-grid-cell");
            __builder.OpenElement(100, "label");
            __builder.AddAttribute(101, "class", "label");
            __builder.AddContent(102, 
#nullable restore
#line 91 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                      functionModel.UpdatedTime?.ToString("yyyy-MM-dd HH:mm:ss")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "btndiv");
            __builder.OpenComponent<MatBlazor.MatButton>(106);
            __builder.AddAttribute(107, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Function\FunctionView.razor"
                                          () => Back()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(110, "Back");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
