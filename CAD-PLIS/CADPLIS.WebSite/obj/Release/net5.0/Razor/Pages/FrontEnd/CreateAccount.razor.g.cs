#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d2a67afc6d155b30659be2e2428121203e3935a"
// <auto-generated/>
#pragma warning disable 1591
namespace CADPLIS.WebSite.Pages.FrontEnd
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 1 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.Domain.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using BlazorStrap.Extensions.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components.FrontEnd.AccountCreation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.Domain.Users;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FrontEndAccountLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createAccount")]
    public partial class CreateAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "createAccountSection");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center");
            __builder.AddAttribute(4, "id", "createAccountRow");
            __builder.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.AccountContentForm>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "p-5");
                __builder2.AddMarkupContent(9, "<div class=\"my-5\"><h3 class=\"contentHeader\">Create personal account</h3></div>\r\n                ");
                __builder2.AddMarkupContent(10, "<div class=\"my-5 contentSubHeader\"><p>Please enter the your email to register your account</p></div>\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "my-3");
                __builder2.AddMarkupContent(13, "<label class=\"inputDescLabel mx-1 font-weight-bold inputLabel\">Email</label>\r\n                    ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                             email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "my-3");
                __builder2.AddMarkupContent(21, "<label class=\"inputDescLabel mx-1 font-weight-bold inputLabel\">Re-enter email</label>\r\n                    ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                             reEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => reEmail = __value, reEmail));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "my-3 inputDescLabel");
                __builder2.OpenComponent<BlazorStrap.BSButton>(29);
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                         onToggle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                           getSendBtnCss()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.ButtonType>(
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                                                        ButtonType.Button

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(34, "Send verification email");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<div class=\"my-3 inputDescLabel\"><span>For any enquiry for verification problem. <a>Contact us.</a></span></div>\r\n                ");
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.HrTextLine>(37);
                __builder2.AddAttribute(38, "Text", "OR");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __builder2.AddMarkupContent(40, "<div class=\"my-3 inputDescLabel\"><span>Already have an Account? <a href=\"/frontLogin\">Login here</a></span></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.AccountBannerImageHolder>(42);
            __builder.AddAttribute(43, "BackgroundImageUrl", "/images/Img_002.jpeg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenComponent<BlazorStrap.BSModal>(45);
            __builder.AddAttribute(46, "IsCentered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Size>(
#nullable restore
#line 37 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                           Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSModalHeader>(49);
                __builder2.AddAttribute(50, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                             onToggle

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(52, "Information");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalBody>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(56, "<p>Please check email to continue create personal account.</p>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSModalFooter>(58);
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<BlazorStrap.BSButton>(60);
                    __builder3.AddAttribute(61, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorStrap.Color>(
#nullable restore
#line 41 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                         Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
                                                   onToggle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(64, "OK");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(65, (__value) => {
#nullable restore
#line 37 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
               VerticallyCentered = (BlazorStrap.BSModal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n");
            __builder.AddMarkupContent(67, @"<style>
    #createAccountSection #createRow {
        justify-content: space-around;
    }

        #createAccountSection #createRow .inputLabel {
            color: #435471;
            font-size: medium;
        }

    .inputDescLabel, .inputDescLabel span {
        font-size: smaller;
        font-weight: bold;
    }

        .inputDescLabel a {
            color: #1F40E5 !important;
            text-decoration: underline;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreateAccount.razor"
       
    private String email { get; set; }
    private String reEmail { get; set; }

    BSModal VerticallyCentered;

    void onToggle(MouseEventArgs e)
    {
        VerticallyCentered.Toggle();
    }

    private String getSendBtnCss()
    {
        Console.WriteLine("## getSendBtnCss: " + String.IsNullOrEmpty(email) + " // " + email + " // " + String.IsNullOrEmpty(reEmail) + " // " + reEmail);
        if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(reEmail))
        {
            return "w-100 confirmBtn";
        }
        return "w-100 disabled confirmBtn";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
