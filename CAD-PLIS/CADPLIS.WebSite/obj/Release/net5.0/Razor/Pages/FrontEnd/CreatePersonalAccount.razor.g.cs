#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a10a9ed59d867935989b7da5606e0f3c0a380b8"
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
#line 35 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.Domain.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
using CADPLIS.WebSite.Components.FrontEnd.AccountCreation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FrontEndAccountLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createPersonalAccount")]
    public partial class CreatePersonalAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "createPersonalAccount");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row mb-5 justify-content-center");
            __builder.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.AccountContentForm>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "<div id=\"headerText\" class=\"row\"><h3 class=\"contentHeader\">\r\n                    Create personal account\r\n                </h3></div>\r\n            \r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "id", "stepsHolder");
                __builder2.AddAttribute(9, "class", "row d-none d-lg-flex d-xl-flex");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "id", "stepOneTabHolder");
                __builder2.AddAttribute(12, "class", "col" + " m-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                 isSelectedStep(1)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                              () => { currentStep = 1; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "<label>Step 1</label> <br> ");
                __builder2.AddMarkupContent(15, "<label>Login Credential</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "id", "stepTwoTabHolder");
                __builder2.AddAttribute(19, "class", "col" + " m-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                 isSelectedStep(2)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                              () => { currentStep = 2; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(21, "<label>Step 2</label> <br> ");
                __builder2.AddMarkupContent(22, "<label>Personal information</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "id", "stepThreeTabHolder");
                __builder2.AddAttribute(26, "class", "col" + " m-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 22 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                   isSelectedStep(3)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                                () => { currentStep = 3; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "<label>Step 3</label> <br> ");
                __builder2.AddMarkupContent(29, "<label>Residential address</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "id", "stepFourTabHolder");
                __builder2.AddAttribute(33, "class", "col" + " m-3" + " p-2" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                  isSelectedStep(4)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                               () => { currentStep = 4; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(35, "<label>Step 4</label> <br> ");
                __builder2.AddMarkupContent(36, "<label>Employment information</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            \r\n            \r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "id", "stepsHolder");
                __builder2.AddAttribute(40, "class", "row d-flex d-lg-none d-xl-none p-3");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "id", "stepOneTabHolder");
                __builder2.AddAttribute(43, "class", "col-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                               isSelectedStep(1)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                            () => { currentStep = 1; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "<label>Step 1</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "id", "stepTwoTabHolder");
                __builder2.AddAttribute(49, "class", "col-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 35 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                               isSelectedStep(2)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                            () => { currentStep = 2; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(51, "<label>Step 2</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "id", "stepThreeTabHolder");
                __builder2.AddAttribute(55, "class", "col-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 38 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                 isSelectedStep(3)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                              () => { currentStep = 3; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "<label>Step 3</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "id", "stepFourTabHolder");
                __builder2.AddAttribute(61, "class", "col-3" + " p-3" + " rounded-3" + " stepDiv" + " " + (
#nullable restore
#line 41 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                isSelectedStep(4)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                             () => { currentStep = 4; }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(63, "<label>Step 4</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            \r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "id", "stepsContentHolder");
                __builder2.AddAttribute(67, "class", "row");
#nullable restore
#line 47 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                 switch (currentStep)
                {
                    case 1:

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.LoginCredentialForm>(68);
                __builder2.AddAttribute(69, "OnNextActionClicked", new System.Action(
#nullable restore
#line 50 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                   OnNextActionClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "OnPrevActionClicked", new System.Action(
#nullable restore
#line 50 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                              OnPrevActionClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 51 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                        break;
                    case 2:
                        

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.PersonalInformationForm>(71);
                __builder2.CloseComponent();
#nullable restore
#line 55 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                        break;
                    case 3:

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.ResidentialAddressForm>(72);
                __builder2.CloseComponent();
#nullable restore
#line 58 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                        break;
                    case 4:

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.EmploymentInformationForm>(73);
                __builder2.AddAttribute(74, "OnNextActionClicked", new System.Action(
#nullable restore
#line 60 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                         OnNextActionClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "OnPrevActionClicked", new System.Action(
#nullable restore
#line 60 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                                                                                                                    OnPrevActionClicked

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 61 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
                        break;
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.AccountCreation.AccountBannerImageHolder>(77);
            __builder.AddAttribute(78, "BackgroundImageUrl", "/images/Img_003.jpeg");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.AddMarkupContent(80, "<style>\r\n    /*    #imgHolder {\r\n        background-image: url(images/Img_003.jpeg);\r\n        background-size: cover;\r\n        background-repeat: no-repeat;\r\n        background-position: center;\r\n        height: 120vh;\r\n    }*/\r\n\r\n    #headerText {\r\n        color: #2E4161;\r\n        font-weight: bolder;\r\n    }\r\n\r\n    #stepsHolder .stepDiv {\r\n        color: #848484;\r\n        background: #E9E9E9;\r\n        text-align: center;\r\n        align-self: center;\r\n        background: linear-gradient( 135deg, #E9E9E9, #E9E9E9) top left, linear-gradient( 245deg, transparent 25px, #E9E9E9 0) top right, linear-gradient( 295deg, transparent 25px, #E9E9E9 0) bottom right, linear-gradient( 45deg, #E9E9E9, #E9E9E9) bottom left;\r\n        background-repeat: no-repeat;\r\n        background-size: 51% 51%;\r\n        text-align: left;\r\n    }\r\n\r\n        #stepsHolder .stepDiv.selected {\r\n            background: #2E4161;\r\n            background: linear-gradient( 135deg, #2E4161, #2E4161) top left, linear-gradient( 245deg, transparent 25px, #2E4161 0) top right, linear-gradient( 295deg, transparent 25px, #2E4161 0) bottom right, linear-gradient( 45deg, #2E4161, #2E4161) bottom left;\r\n            color: #FFF;\r\n            background-repeat: no-repeat;\r\n            background-size: 51% 51%;\r\n            text-align: left;\r\n        }\r\n\r\n        #stepsHolder .stepDiv:last-child {\r\n            color: #848484;\r\n            background: #E9E9E9;\r\n            background-repeat: no-repeat;\r\n            background-size: 51% 51%;\r\n            text-align: left;\r\n            padding-left: 15px !important;\r\n        }\r\n\r\n            #stepsHolder .stepDiv:last-child.selected {\r\n                background: #2E4161;\r\n                color: #FFF;\r\n                background-repeat: no-repeat;\r\n                background-size: 51% 51%;\r\n                text-align: left;\r\n            }\r\n\r\n        #stepsHolder .stepDiv label {\r\n            font-size: small;\r\n        }\r\n\r\n            #stepsHolder .stepDiv label:first-child {\r\n                font-weight: bold;\r\n                font-size: large;\r\n            }\r\n\r\n    /* Next button in each section*/\r\n    #nextBtnDiv #nextBtn {\r\n        background-color: #2E4161;\r\n    }\r\n\r\n        #nextBtnDiv #nextBtn.disabled {\r\n            background-color: #84ABCA;\r\n            color: #FFF;\r\n        }\r\n\r\n    @media only screen and (max-width: 970px) {\r\n        #stepsHolder .stepDiv {\r\n            color: #848484;\r\n            background: #E9E9E9;\r\n            text-align: center;\r\n            align-self: center;\r\n            background: linear-gradient( 135deg, #E9E9E9, #E9E9E9) top left, linear-gradient( 215deg, transparent 25px, #E9E9E9 0) top right, linear-gradient( 320deg, transparent 25px, #E9E9E9 0) bottom right, linear-gradient( 45deg, #E9E9E9, #E9E9E9) bottom left;\r\n            background-repeat: no-repeat;\r\n            background-size: 51% 51%;\r\n        }\r\n\r\n            #stepsHolder .stepDiv.selected {\r\n                background: #2E4161;\r\n                background: linear-gradient( 135deg, #2E4161, #2E4161) top left, linear-gradient( 215deg, transparent 25px, #2E4161 0) top right, linear-gradient( 320deg, transparent 25px, #2E4161 0) bottom right, linear-gradient( 45deg, #2E4161, #2E4161) bottom left;\r\n                color: #FFF;\r\n                background-repeat: no-repeat;\r\n                background-size: 51% 51%;\r\n            }\r\n    }\r\n\r\n    #stepsContentHolder .formHeader {\r\n        font-size: small;\r\n        font-weight: bold;\r\n    }\r\n\r\n    #stepsContentHolder .form-group label {\r\n        color: #2E4161;\r\n        font-weight: bold;\r\n    }\r\n    /* Dropdown CSS*/\r\n    #stepsContentHolder .btn.dropdown-toggle {\r\n        width: 100%;\r\n        /* Border Class */\r\n        border: 1px solid #dee2e6 !important;\r\n        /* Rounded Class */\r\n        border-radius: 0.25rem !important;\r\n    }\r\n\r\n    #stepsContentHolder .dropdown-menu {\r\n        width: 100%;\r\n    }\r\n\r\n    #stepsContentHolder .row {\r\n        justify-content: space-around !important;\r\n        align-items: center !important;\r\n    }\r\n\r\n    #stepsContentHolder label {\r\n        margin-bottom: 0;\r\n    }\r\n\r\n    #stepsContentHolder button.disabled {\r\n        border-color: transparent;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 199 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\CreatePersonalAccount.razor"
       
    [Parameter]
    public int currentStep { get; set; } = 1;

    private String isSelectedStep(int step)
    {
        if (currentStep == step)
        {
            return "selected";
        }
        return "";
    }

    private void OnPrevActionClicked()
    {
        Console.WriteLine("## OnPrevActionClicked: " + currentStep);
        if (currentStep > 1)
        {
            currentStep -= 1;
            StateHasChanged();
        }
    }
    private void OnNextActionClicked()
    {
        Console.WriteLine("## OnNextActionClicked: " + currentStep);
        if (currentStep < 4)
        {
            currentStep += 1;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
