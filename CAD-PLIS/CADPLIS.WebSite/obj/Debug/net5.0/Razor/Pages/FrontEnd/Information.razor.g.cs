#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4886564363f562a181bac1e995047ffdb80fb56"
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
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FrontEndLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/information")]
    public partial class Information : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "pilotLicenceInformationSection");
            __builder.OpenComponent<CADPLIS.WebSite.Components.LandingPage.Banner>(2);
            __builder.AddAttribute(3, "bannerImgUrl", "/images/Img_005.jpeg");
            __builder.AddAttribute(4, "bannerTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 8 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
                                                              bannerTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    \r\n    ");
            __builder.OpenComponent<BlazorStrap.BSBreadcrumb>(6);
            __builder.AddAttribute(7, "Class", "m-5 bg-none");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSBreadcrumbItem>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(11, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSBreadcrumbItem>(13);
                __builder2.AddAttribute(14, "IsActive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Class", "currentPage");
                __builder2.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(17, "Information");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
     if (informationList != null && informationList.Count > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
         foreach (InformationObject information in informationList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.InformationCard>(18);
            __builder.AddAttribute(19, "title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
                                     information.title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "imgSrc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
                                                                 information.imgUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "links", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Tuple<System.String, System.String>>>(
#nullable restore
#line 19 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
                                                                                             information.links

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.AddMarkupContent(23, "<style>\r\n    #pilotLicenceInformationSection {\r\n    }\r\n\r\n    .bg-none {\r\n        background-color: transparent !important;\r\n    }\r\n\r\n    .currentPage {\r\n        text-decoration: underline !important;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\Information.razor"
       
    public class InformationObject
    {
        public String imgUrl { get; set; }
        public String title { get; set; }
        public List<Tuple<String, String>> links { get; set; }
    }
    private List<String> bannerTitle = new List<string> { "Pilot licence's information", "Requirements for commercial flying" };
    public List<InformationObject> informationList = new List<InformationObject>();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        informationList.Add(new InformationObject { imgUrl = "/images/Img_004.jpeg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Private Pilot's Licence", "/informationDetail"), new Tuple<String, String>("Professional Pilot's Licence", "/informationDetail") }, title = "Aeroplanes" });
        informationList.Add(new InformationObject { imgUrl = "/images/Img_006.jpeg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Private Pilot's Licence", "/informationDetail"), new Tuple<String, String>("Rating / Endorsement / Certificate", "/informationDetail") }, title = "Helicopters" });
        informationList.Add(new InformationObject { imgUrl = "/images/shutterstock_600097127.jpg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Initial application", "/informationDetail"), new Tuple<String, String>("Application Renewal", "/informationDetail"), new Tuple<String, String>("Notificationof Unifitness and Medical Clearance", "/informationDetail") }, title = "Medical requirements" });
        informationList.Add(new InformationObject { imgUrl = "/images/shutterstock_600097127.jpg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Register for a professional pilot exam", "/informationDetail"), new Tuple<String, String>("Verify your theoretical knowledge exam results", "/informationDetail"), new Tuple<String, String>("Exam timetables", "/informationDetail") }, title = "Examinations" });
        informationList.Add(new InformationObject { imgUrl = "/images/shutterstock_600097127.jpg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Register for a professional pilot exam", "/informationDetail"), new Tuple<String, String>("Verify your theoretical knowledge exam results", "/informationDetail"), new Tuple<String, String>("Exam timetables", "/informationDetail") }, title = "Instructors and Examiners" });
        informationList.Add(new InformationObject { imgUrl = "/images/shutterstock_600097127.jpg", links = new List<Tuple<String, String>> { new Tuple<String, String>("Conversion of an EASA flight crew licence to a HK part equivalent licence", "/informationDetail"), new Tuple<String, String>("Recognition of ICAO licences in HK airspace", "/informationDetail"), new Tuple<String, String>("Convert your ICAO instructor certificates", "/informationDetail"), new Tuple<String, String>("Validations", "/informationDetail"), new Tuple<String, String>("Verification of a third country ICAO licence", "/informationDetail") }, title = "Non Hong Kong licences" });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
