// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CADPLIS.WebSite.Pages.User
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
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using CADPLIS.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using CADPLIS.WebSite.Notice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using CADPLIS.Application.Contracts.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
using CADPLIS.Domain.CodeLists;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/User/UserInfo")]
    public partial class UserInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\UserInfo.razor"
 
    Dictionary<string, string> dicUserType = new Dictionary<string, string>();
    Dictionary<string, string> dciState = new Dictionary<string, string>();

    private Paginator<UserDto> paginator = new();
    private int PageSize { get; set; } = 10;
    private int PageIndex { get; set; } = 0;
    private int PageCount { get; set; }
    private string userId { get; set; }
    private int? uId;
    private string email { get; set; }

    [CascadingParameter] public Error Error { get; set; }
    [Parameter] public int Id { get; set; }
    [Inject] IViewNotifier viewNotifier { get; set; }
    [Parameter] public string action { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetUserList();
        await SetUserType();
        await SetUserStatus();

    }

    async Task GetUserList()
    {
        //httpClient.DefaultRequestHeaders.Add("currentRole", "admin");
        var url = $"api/User/GetPageUsers/pageSize/{PageSize}/pageIndex/{PageIndex}?userId={userId}&uId={uId}&email={email}";
        var result = await httpRepository.GetJsonAsync<ApiResponse<Paginator<UserDto>>>(url);
        if (result.IsSuccessStatusCode)
        {
            paginator = result.Result;
            PageCount = paginator.pageCount;
        }
    }

    async Task OnPage(MatPaginatorPageEvent e)
    {
        PageSize = e.PageSize;
        PageIndex = e.PageIndex;
        await GetUserList();
    }

    void Edit(int id)
    {
        Id = id;
        action = "edit";
        navigationManager.NavigateTo($"/User/Edit/{Id}");
    }
    void AddUser()
    {
        navigationManager.NavigateTo($"/User/Add");
    }
    void View(int id)
    {
        Id = id;
        navigationManager.NavigateTo($"/User/UserView/{Id}");
    }

    async Task ChangePwd(Guid id)
    {
        var result = await MatDialogService.OpenAsync(typeof(ChangePassword),
                new MatDialogOptions()
                    {
                        Attributes = new Dictionary<string, object>() {
                        { "UserId", id },
                            }
                    });
        var isSuccess = result.ToString().Equals("True");
        if (isSuccess)
        {
            await GetUserList();
        }
    }

    async Task Search()
    {
        await GetUserList();
    }

    async Task DeleteUser(Guid id)
    {
        var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
        if (boolDelete)
        {
            var result = await httpRepository.DeleteAsync<ApiResponse>($"/api/Account/DeleteUser/{id}");
            if (result.IsSuccessStatusCode)
            {
                viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                await GetUserList();
            }
            else
            {
                Error.ShowError(result.Message);
            }

        }
    }

    async Task SetUserType()
    {
        var rsp = await GetListByType("UserType");
        var userTypes = rsp.Result;
        foreach (var item in userTypes)
        {
            dicUserType.Add(item.Value, item.Description);
        }
    }
    async Task SetUserStatus()
    {
        var rsp = await GetListByType("ActivationStatus");
        var userTypes = rsp.Result;
        foreach (var item in userTypes)
        {
            dciState.Add(item.Value, item.Description);
        }
    }


    async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
    {
        string url = $"api/CodeList/GetListByType/{type}";
        var result = await httpRepository.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
        if (result.IsSuccessStatusCode)
        {
            return result;
        }
        return null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpRepository httpRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatDialogService MatDialogService { get; set; }
    }
}
#pragma warning restore 1591
