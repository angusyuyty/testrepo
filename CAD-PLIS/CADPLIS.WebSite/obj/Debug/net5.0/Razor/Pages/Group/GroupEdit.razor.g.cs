#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a0a0fa3258a7808c37b88746714790fef2b1a9"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.Group
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Group/Edit/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Group/Add")]
    public partial class GroupEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
          Id!=default? "Group Edit": "Group Add"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                            editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "mat-layout-grid mat-layout-grid-align-left");
                __builder2.AddAttribute(13, "style", "max-width: 800px;");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(16, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Group ID</label></div>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_0(__builder2, 19, 20, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                , 21, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                              true

#line default
#line hidden
#nullable disable
                , 22, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.GroupId

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.GroupId = __value, groupModel.GroupId)), 24, () => groupModel.GroupId);
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                            ()=>groupModel.GroupId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(31, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Group Name</label></div>\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_2(__builder2, 34, 35, 
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                , 36, 
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.GroupDescription

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.GroupDescription = __value, groupModel.GroupDescription)), 38, () => groupModel.GroupDescription);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(42, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created By</label></div>\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_3(__builder2, 45, 46, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                , 47, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                , 48, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.CreatedBy

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.CreatedBy = __value, groupModel.CreatedBy)), 50, () => groupModel.CreatedBy);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(54, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created User Role</label></div>\r\n                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_4(__builder2, 57, 58, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                , 59, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                , 60, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.CreatedUserRoleId

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.CreatedUserRoleId = __value, groupModel.CreatedUserRoleId)), 62, () => groupModel.CreatedUserRoleId);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(66, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Created date</label></div>\r\n                ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_5(__builder2, 69, 70, 
#nullable restore
#line 48 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
                , 71, 
#nullable restore
#line 48 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                , 72, 
#nullable restore
#line 48 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.CreatedTimeText

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.CreatedTimeText = __value, groupModel.CreatedTimeText)), 74, () => groupModel.CreatedTimeText);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(78, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated By </label></div>\r\n                ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_6(__builder2, 81, 82, 
#nullable restore
#line 56 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                , 83, 
#nullable restore
#line 56 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                , 84, 
#nullable restore
#line 56 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.UpdatedBy

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.UpdatedBy = __value, groupModel.UpdatedBy)), 86, () => groupModel.UpdatedBy);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(90, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated User Role </label></div>\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_7(__builder2, 93, 94, 
#nullable restore
#line 64 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                , 95, 
#nullable restore
#line 64 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                , 96, 
#nullable restore
#line 64 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.UpdatedUserRoleId

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.UpdatedUserRoleId = __value, groupModel.UpdatedUserRoleId)), 98, () => groupModel.UpdatedUserRoleId);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(102, "<div class=\"mat-layout-grid-cell\"><label class=\"label\">Last updated date </label></div>\r\n                ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit.TypeInference.CreateMatTextField_8(__builder2, 105, 106, 
#nullable restore
#line 72 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
                , 107, 
#nullable restore
#line 72 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                , 108, 
#nullable restore
#line 72 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                                groupModel.UpdatedTimeText

#line default
#line hidden
#nullable disable
                , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => groupModel.UpdatedTimeText = __value, groupModel.UpdatedTimeText)), 110, () => groupModel.UpdatedTimeText);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "btndiv");
            __builder.OpenComponent<MatBlazor.MatButton>(114);
            __builder.AddAttribute(115, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 82 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                        () => SaveData()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(118, "Save");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.OpenComponent<MatBlazor.MatButton>(120);
            __builder.AddAttribute(121, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\Group\GroupEdit.razor"
                                          () => Back()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(124, "Back");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CADPLIS.WebSite.Pages.Group.GroupEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Required", __arg0);
        __builder.AddAttribute(__seq1, "Outlined", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Outlined", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
