#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc90c83d5261db5ce475d6fbfe9da84d2cc36c3c"
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
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
using CADPLIS.WebSite.Extension;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FrontEndLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/newsDetail")]
    public partial class LatestNewsDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "latestNewsDetailsSection");
            __builder.OpenComponent<BlazorStrap.BSRow>(2);
            __builder.AddAttribute(3, "id", "bannerImage");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        &nbsp;\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    \r\n    ");
            __builder.OpenComponent<BlazorStrap.BSBreadcrumb>(7);
            __builder.AddAttribute(8, "Class", "m-5 bg-none");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSBreadcrumbItem>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSBreadcrumbItem>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "News");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSBreadcrumbItem>(18);
                __builder2.AddAttribute(19, "IsActive", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Class", "currentPage text-de");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Details");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n    \r\n    ");
            __builder.OpenComponent<BlazorStrap.BSRow>(24);
            __builder.AddAttribute(25, "Class", "w-100 p-4");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorStrap.BSCol>(27);
                __builder2.AddAttribute(28, "id", "informationListCol");
                __builder2.AddAttribute(29, "Class", "col-12 col-lg-4 col-xl-4 mr-4");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "border rounded h-100 bg-white");
#nullable restore
#line 24 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                 foreach (Tuple<int, int?, String> information in GetRootMenuList())
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.InformationListItem>(33);
                    __builder3.AddAttribute(34, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                  () => SetNewsDetailId(information.Item1, information.Item2)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(35, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                    information.Item1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ParentId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                  information.Item2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                             information.Item3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "SelectedCatItemId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                                                                    selectedCatId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "SelectedItemId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 26 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                                                                                                    selectedItemId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "CssClass", "p-3");
                    __builder3.CloseComponent();
#nullable restore
#line 29 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                     if (selectedCatId.HasValue && information.Item1 == selectedCatId)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                         foreach (Tuple<int, int?, String> informationItem in GetDetailMenuItemList(selectedCatId.Value))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<CADPLIS.WebSite.Components.FrontEnd.InformationListItem>(41);
                    __builder3.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                          () => SetNewsDetailId(informationItem.Item1, informationItem.Item2)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(43, "Id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                    informationItem.Item1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ParentId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                      informationItem.Item2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                                                     informationItem.Item3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "SelectedCatItemId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                                                                                                selectedCatId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "SelectedItemId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 33 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                                                                                                                                                                                                                                                                                selectedItemId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "CssClass", "p-2");
                    __builder3.CloseComponent();
#nullable restore
#line 36 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                     
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n        \r\n        ");
                __builder2.OpenComponent<BlazorStrap.BSCol>(50);
                __builder2.AddAttribute(51, "id", "newsDetailCol");
                __builder2.AddAttribute(52, "Class", "col-12 col-lg-6 col-xl-6 p-5");
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 43 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
             if (selectedItemId.HasValue)
            {
                NewsDetail newsDetail = newsDetailList.Find(x => x.id == selectedItemId.Value);

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<BlazorStrap.BSRow>(54);
                    __builder3.AddAttribute(55, "id", "newsHeader");
                    __builder3.AddAttribute(56, "Class", "m-3");
                    __builder3.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(58, "span");
                        __builder4.AddContent(59, 
#nullable restore
#line 47 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                           newsDetail.title

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                    __builder3.OpenComponent<BlazorStrap.BSRow>(61);
                    __builder3.AddAttribute(62, "id", "newsSubHeader");
                    __builder3.AddAttribute(63, "Class", "mb-4");
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(65, "span");
                        __builder4.AddContent(66, 
#nullable restore
#line 50 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                           newsDetail.subTitle

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n                ");
                    __builder3.OpenComponent<BlazorStrap.BSRow>(68);
                    __builder3.AddAttribute(69, "id", "newsContent");
                    __builder3.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(71, "span");
                        __builder4.AddContent(72, 
#nullable restore
#line 53 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
                           newsDetail.description

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 55 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n");
            __builder.AddMarkupContent(74, @"<style>
    #pilotLicenceInformationSection {
    }

    .bg-none {
        background-color: transparent !important;
    }

    .currentPage {
        text-decoration: underline !important;
    }

    #newsListCol .newsListItem {
        background-color: #F6F6F6;
        color: #2E4161;
    }

    #newsListCol .selectedItem {
        background-color: #2E4161;
        color: #F4F4F4;
        font-weight: bold;
    }

    #newsDetailCol {
        background-color: #FFFFFF;
    }

        #newsDetailCol #newsHeader {
            color: #2E4161;
            text-align: center;
            font-weight: bold;
            font-size: x-large;
        }

        #newsDetailCol #newsSubHeader {
            color: #7C7C7C;
            font-weight: bold;
            font-size: medium;
        }

        #newsDetailCol #newsContent {
            color: #7C7C7C;
            font-weight: bold;
            font-size: medium;
        }

    #latestNewsDetailsSection #bannerImage {
        height: 45vh;
        background-image: url(/images/shutterstock_129707585.jpg);
        background-repeat: no-repeat;
        background-size: cover;
        background-position: top;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetail.razor"
       
    public class NewsDetail
    {
        public int id { get; set; }
        public String title { get; set; }
        public String subTitle { get; set; }
        public String description { get; set; }
    }
    private int selectedNewsId = 0;
    public List<Tuple<int, int?, String>> newsList { get; set; } = new List<Tuple<int, int?, String>>();
    public List<NewsDetail> newsDetailList { get; set; } = new List<NewsDetail>();
    private int? selectedCatId { get; set; }
    private int? selectedItemId { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        newsList.Add(new Tuple<int, int?, String>(1, null, "Aeroplanes"));
        newsList.Add(new Tuple<int, int?, String>(2, 1, "Flight Crew's Licence requirement update"));
        newsList.Add(new Tuple<int, int?, String>(3, 1, "Private Pilot's Licence requirement update"));

        newsDetailList.Add(new NewsDetail { id = 1, title = "Professional Pilot's Licence requirements update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });
        newsDetailList.Add(new NewsDetail { id = 2, title = "Flight Crew's Licence requirement update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });
        newsDetailList.Add(new NewsDetail { id = 3, title = "Private Pilot's Licence requirement update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });

        NavigationManagerExtensions.TryGetQueryString<int>(NavManager, "i", out selectedNewsId);
    }

    public List<Tuple<int, int?, String>> GetRootMenuList()
    {
        return newsList.FindAll(x => x.Item2 == null);
    }

    public List<Tuple<int, int?, String>> GetDetailMenuItemList(int rootItemId)
    {
        return newsList.FindAll(x => x.Item2.HasValue && x.Item2.Value == rootItemId);
    }

    private void SetNewsDetailId(int id, int? parentId)
    {
        if (!parentId.HasValue)
        {
            if (selectedCatId == id)
            {
                selectedCatId = null;
            }
            else
            {
                selectedCatId = id;
            }
        }
        else
        {
            selectedItemId = id;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591