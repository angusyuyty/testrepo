#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b60ea81a6a899e954666e90fd74b31dd3438bf"
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
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\_Imports.razor"
using CADPLIS.WebSite.Components.FrontEnd;

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
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FrontEndLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/landing")]
    public partial class LandingPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorStrap.BSRow>(0);
            __builder.AddAttribute(1, "Class", "p-0 m-0");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCol>(3);
                __builder2.AddAttribute(4, "Class", "col-12 p-0 m-0 mainContent");
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.Banner>(6);
                    __builder3.AddAttribute(7, "bannerImgUrl", "/images/shutterstock_171507251.jpg");
                    __builder3.AddAttribute(8, "bannerTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 8 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor"
                                                                                bannerTitle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "bannerContainerCss", "margin-bottom: 0px;");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.Carousel>(11);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.Steps>(13);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.NewsCarousel>(15);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.FAQ>(17);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<BlazorStrap.BSCol>(19);
                __builder2.AddAttribute(20, "Class", "col jumpMenuCol d-none d-lg-flex d-xl-flex");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.LandingPage.JumpMenu>(22);
                    __builder3.AddAttribute(23, "links", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 15 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor"
                          links

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.AddMarkupContent(25, @"<style>
    .landingHeader {
        justify-content: center;
    }

    .mainContent {
        background-color: #F7FBFD;
    }

    .sectionTitle {
        font-family: 'Roboto', sans-serif;
        font-size: 36px;
        font-weight: 600;
        font-stretch: normal;
        font-style: normal;
        line-height: normal;
        letter-spacing: normal;
        color: #35496e;
        text-align: center;
    }

    .jumpMenuCol {
        position: absolute;
        left: 95%;
    }

    #bannerContainer {
        margin-bottom: 15vh;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LandingPage.razor"
 
    private List<CarouselObject> firstCarouselList = new List<CarouselObject>();
    private List<CarouselObject> secondCarouselList = new List<CarouselObject>();
    private List<String> links = new List<string>();
    private List<String> bannerTitle = new List<string>{ "Welcome to", "Personnel Licensing Information System" };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        firstCarouselList.Add(new CarouselObject { id = 1, title = "How to apply for \n Aircraft Maintenance Licence", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });
        firstCarouselList.Add(new CarouselObject { id = 2, title = "About Us", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });
        firstCarouselList.Add(new CarouselObject { id = 3, title = "Contact Us", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });
        firstCarouselList.Add(new CarouselObject { id = 4, title = "Object 4", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });
        firstCarouselList.Add(new CarouselObject { id = 5, title = "Object 5", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });
        firstCarouselList.Add(new CarouselObject { id = 6, title = "Object 6", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_626787275.jpg", learnMoreRoute = "#" });


        secondCarouselList.Add(new CarouselObject { id = 1, title = "Professional Pilot's Licence requirements update", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_129707585.jpg", learnMoreRoute = "#" });
        secondCarouselList.Add(new CarouselObject { id = 2, title = "Flight Crew's Licence requirement update", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/shutterstock_750976636.jpg", learnMoreRoute = "#" });
        secondCarouselList.Add(new CarouselObject { id = 3, title = "Private Pilot's Licence requirement update", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/img02.jpg", learnMoreRoute = "#" });
        secondCarouselList.Add(new CarouselObject { id = 4, title = "Object 4", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/img02.jpg", learnMoreRoute = "#" });
        secondCarouselList.Add(new CarouselObject { id = 5, title = "Object 5", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/img02.jpg", learnMoreRoute = "#" });
        secondCarouselList.Add(new CarouselObject { id = 6, title = "Object 6", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vitae libero sapien. Vestibulum elit ex, sodales quis fringilla at, suscipit ut eros. Sed eu bibendum magna. Nam suscipit mattis ante et sodales. Proin elit erat, gravida non nibh id, sodales hendrerit justo. Cras ac ex vel leo vulputate tristique. Suspendisse hendrerit, ex non aliquet mollis", imgUrl = "/images/img02.jpg", learnMoreRoute = "#" });

        //links.Add("bannerContainer");
        links.Add("carouselSection");
        links.Add("stepsSection");
        links.Add("newsCarousel");
        links.Add("faqSection");
    }

    protected async override Task OnAfterRenderAsync(bool firstrender)
    {
        if (firstrender)
        {
            await js.InvokeAsync<object>("initFlickity");
            await js.InvokeAsync<object>("jumpMenuCss");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
