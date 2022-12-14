// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CADPLIS.WebSite.Pages.FrontEnd
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Components.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.WebSite.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\project\CAD-PLIS\CADPLIS.WebSite\_Imports.razor"
using BlazorStrap.Extensions.TreeView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\project\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetails.razor"
using CADPLIS.WebSite.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetails.razor"
using CADPLIS.WebSite.Components.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\project\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetails.razor"
using CADPLIS.WebSite.Components.LandingPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\project\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetails.razor"
using CADPLIS.WebSite.Extension;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CADPLIS.WebSite.Shared.FrontEndLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/newsDetail")]
    public partial class LatestNewsDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "D:\project\CAD-PLIS\CADPLIS.WebSite\Pages\FrontEnd\LatestNewsDetails.razor"
       
    public class NewsDetail
    {
        public int id { get; set; }
        public String title { get; set; }
        public String subTitle { get; set; }
        public String description { get; set; }
    }
    private int selectedNewsId = 0;
    public List<Tuple<int, String>> newsList { get; set; } = new List<Tuple<int, string>>();
    public List<NewsDetail> newsDetailList { get; set; } = new List<NewsDetail>();
    public NewsDetail selectedNewsDetail { get; set; } = null;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        newsList.Add(new Tuple<int, String>(1, "Professional Pilot's Licence requirements update"));
        newsList.Add(new Tuple<int, String>(2, "Flight Crew's Licence requirement update"));
        newsList.Add(new Tuple<int, String>(3, "Private Pilot's Licence requirement update"));

        newsDetailList.Add(new NewsDetail { id = 1, title = "Professional Pilot's Licence requirements update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });
        newsDetailList.Add(new NewsDetail { id = 2, title = "Flight Crew's Licence requirement update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });
        newsDetailList.Add(new NewsDetail { id = 3, title = "Private Pilot's Licence requirement update", subTitle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis nex condimentum quam. Fusce pellentesque faucibus lorem at viverra. Integer at feugiat odio. In placerat euismod risus proin.", description = "Where does it come from? Contrary to popular belief, Lorem lpsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin workds, consectetur, from a Lorem lpsum passage, and going throught the cites of the word in classical literature, discovered the undoubtable source. Lorem lpsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem lpsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32." });

        NavigationManagerExtensions.TryGetQueryString<int>(NavManager, "i", out selectedNewsId);
        //isSelecteditem(1);
    }

    private void getNewsDetail(int id)
    {
        NewsDetail newsDetail = newsDetailList.Find(x => x.id == id);
        selectedNewsDetail = newsDetail;
    }

    private String isSelecteditem(int id)
    {
        if (selectedNewsDetail != null && selectedNewsDetail.id == id)
        {
            return "selectedItem newsListItem";
        }
        return "newsListItem";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
