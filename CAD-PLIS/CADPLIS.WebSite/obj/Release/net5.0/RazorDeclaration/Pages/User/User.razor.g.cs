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
#line 1 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
using CADPLIS.Application.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
using CADPLIS.Application.Contracts.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
using CADPLIS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
using CADPLIS.WebSite.Notice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
using CADPLIS.WebSite.Shared;

#line default
#line hidden
#nullable disable
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
       
    ApplicationUserDto currentUser { get; set; } = new();
    [Inject] IViewNotifier viewNotifier { get; set; }
    protected List<SelectItem<Guid>> roleSelections { get; set; } = new();
    [Inject] HttpClient httpClient { get; set; }
    [Inject] IMatToaster Toaster { get; set; }

    [Parameter] public string Id { get; set; }
    private GroupInfoDto groupTree { get; set; } = new GroupInfoDto();
    private GroupInfoDto SelectedParentNode { get; set; }
    [CascadingParameter] public Error Error { get; set; }


    string getUserUrl = "api/Account/GetUserById/{0}";
    string getAllRolesUrl = "api/Account/GetAllRoles";
    string updateUserUrl = "api/Account/UpdateUser";
    protected override async Task OnInitializedAsync()
    {
        await GetUserById(Guid.Parse( Id));
        await GetTreeGroupList();
        await LoadRoles();
        GetGroupWithChildren((List<GroupInfoDto>)groupTree.Chilrens, currentUser.GroupId.ToString());
        await base.OnInitializedAsync();
    }

    async Task GetUserById(Guid id)
    {
        var res = await httpClient.GetJsonAsync<ApiResponse<ApplicationUserDto>>(string.Format(getUserUrl, id));
        if (res.IsSuccessStatusCode)
        {
            currentUser = res.Result;
        }
        else
        {
            Error.ShowError(res.Message);
        }
    }

    protected void UpdateUserRole(SelectItem<Guid> roleSelectionItem)
    {
        //if (currentUser.UserName.ToLower() != DefaultUserNames.Administrator || roleSelectionItem.DisplayValue != DefaultRoleNames.Administrator)
        roleSelectionItem.Selected = !roleSelectionItem.Selected;
    }

    protected async Task LoadRoles()
    {
        try
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<List<RoleInfoDto>>>(getAllRolesUrl);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Result;
                roleSelections = result.Select(i => new SelectItem<Guid>
                {
                    Id = i.Id,
                    DisplayValue = i.Name,
                    Selected = currentUser.Roles != null && currentUser.Roles.Contains(i.Name)
                }).ToList();
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }
        catch (Exception ex)
        {
            viewNotifier.Show(ex.GetBaseException().Message, ViewNotifierType.Error, "Operation Failed");
        }
    }


    async Task CancelChanges()
    {
        navigationManager.NavigateTo("User/UserInfo");
    }

    async Task UpdateUserAsync()
    {
        var userModel = new UserViewModel
        {
            UserId = currentUser.Id,
            UserName = currentUser.UserName,
            Email = currentUser.Email,
            Roles = roleSelections.Where(i => i.Selected).Select(i => i.DisplayValue).ToList(),
            IsHead = currentUser.IsHead,
            GroupId = SelectedParentNode?.Id
        };
        if (string.IsNullOrEmpty(userModel.GroupId?.ToString()))
        {
            Toaster.Add("user group is required!", MatToastType.Warning, "warning");
            return;
        }
        var result = await httpClient.PutJsonAsync<ApiResponse>(updateUserUrl, userModel);
        if (!result.IsSuccessStatusCode)
        {
            Error.ShowError(result.Message);
        }
        viewNotifier.Show("update success", ViewNotifierType.Success, "success");
        navigationManager.NavigateTo("User/UserInfo");
    }
    async Task GetTreeGroupList()
    {
        var result = await httpClient.GetFromJsonAsync<ApiResponse<List<GroupInfoDto>>>("/api/Account/GetGroupWhithChilds");
        if (result.IsSuccessStatusCode)
        {
            groupTree.GroupName = " Top Group";
            groupTree.Chilrens = result.Result;

        }
        else
        {
            Error.ShowError(result.Message);
        }
    }
    void GetGroupWithChildren(List<GroupInfoDto> parentMenus, string parentId)
    {
        foreach (var item in parentMenus)
        {
            if (item.Id.ToString() == parentId)
            {
                SelectedParentNode = item;
                return;
            }
            else if (item.Chilrens != null)
            {
                GetGroupWithChildren((List<GroupInfoDto>)item.Chilrens, parentId);
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591