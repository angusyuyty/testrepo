#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96296a17071947fbf2c7d88c5f3a48d42f104638"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.UserRoleGroup
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserRoleGroup/Edit/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserRoleGroup/add")]
    public partial class Oper : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                        editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(3);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mat-layout-grid mat-layout-grid-align-left");
                __builder2.AddAttribute(9, "style", "max-width: 800px;");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(12, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-2\"><label class=\"label\">User  ID</label></div>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "mat-layout-grid-cell");
                __Blazor.CADPLIS.WebSite.Pages.UserRoleGroup.Oper.TypeInference.CreateMatSelectValue_0(__builder2, 15, 16, 
#nullable restore
#line 13 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                        userRoleDto.UserId

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                   () => userRoleDto.UserId 

#line default
#line hidden
#nullable disable
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                              ((string userId)=>ChangeUser(userId) )

#line default
#line hidden
#nullable disable
                ), 19, 
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                        UserIds

#line default
#line hidden
#nullable disable
                , 20, 
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                                  v => v.ToString()

#line default
#line hidden
#nullable disable
                , 21, "selectdiv", 22, (itemcon) => (__builder3) => {
                    __builder3.AddContent(23, 
#nullable restore
#line 18 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                         itemcon

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(27, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-2\"><label class=\"label\">Role  ID</label></div>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-5");
                __Blazor.CADPLIS.WebSite.Pages.UserRoleGroup.Oper.TypeInference.CreateMatSelectValue_1(__builder2, 30, 31, 
#nullable restore
#line 29 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                        userRoleDto?.RoleId

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                   () => userRoleDto.RoleId 

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 31 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                              ((string roleId)=>ChangeRole(roleId) )

#line default
#line hidden
#nullable disable
                ), 34, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                        userSelectRoleDtos

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                                             v => v?.RoleId.ToString()

#line default
#line hidden
#nullable disable
                , 36, "selectdiv", 37, (itemcon) => (__builder3) => {
                    __builder3.AddContent(38, 
#nullable restore
#line 34 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                         itemcon.RoleId

#line default
#line hidden
#nullable disable
                    );
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-4");
                __builder2.OpenElement(42, "p");
                __Blazor.CADPLIS.WebSite.Pages.UserRoleGroup.Oper.TypeInference.CreateMatTextField_2(__builder2, 43, 44, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                , 45, 
#nullable restore
#line 40 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                              userRoleDto.RoleName

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userRoleDto.RoleName = __value, userRoleDto.RoleName)), 47, () => userRoleDto.RoleName);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "mat-layout-grid-inner");
                __builder2.AddMarkupContent(51, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-2\"><label class=\"label\">Group</label></div>\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-8");
                __builder2.OpenComponent<MatBlazor.MatChipSet>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 50 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                     foreach (var group in groupList)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatChip>(56);
                    __builder3.AddAttribute(57, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                         group.DisplayValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "LeadingIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                                            (group.Selected) ? "done" : ""

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                                                                                         ()=>UpdateGroup(group)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 53 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "mat-layout-grid mat-layout-grid-align-middle");
            __builder.AddAttribute(63, "style", "max-width: 800px;");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "mat-layout-grid-inner");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "mat-layout-grid-cell");
            __builder.OpenComponent<MatBlazor.MatButton>(68);
            __builder.AddAttribute(69, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                _ => SaveData()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(72, "Save");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenComponent<MatBlazor.MatButton>(74);
            __builder.AddAttribute(75, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\UserRoleGroup\Oper.razor"
                                                  ()=>navigationManager.NavigateTo("UserRoleGroup/Index")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(78, "Back");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CADPLIS.WebSite.Pages.UserRoleGroup.Oper
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatSelectValue_0<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Collections.Generic.IReadOnlyList<TItem> __arg3, int __seq4, global::System.Func<TItem, TValue> __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectValue<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueExpression", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "Items", __arg3);
        __builder.AddAttribute(__seq4, "ValueSelector", __arg4);
        __builder.AddAttribute(__seq5, "Class", __arg5);
        __builder.AddAttribute(__seq6, "ItemTemplate", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMatSelectValue_1<TValue, TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Collections.Generic.IReadOnlyList<TItem> __arg3, int __seq4, global::System.Func<TItem, TValue> __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg6)
        {
        __builder.OpenComponent<global::MatBlazor.MatSelectValue<TValue, TItem>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueExpression", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "Items", __arg3);
        __builder.AddAttribute(__seq4, "ValueSelector", __arg4);
        __builder.AddAttribute(__seq5, "Class", __arg5);
        __builder.AddAttribute(__seq6, "ItemTemplate", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
