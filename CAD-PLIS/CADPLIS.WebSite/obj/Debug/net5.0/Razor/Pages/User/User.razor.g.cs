#pragma checksum "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d3fe4bb2042a17437e6d12cb8777d2c25d53b77"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>User</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "id", "updateUserForm");
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                      currentUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                   UpdateUserAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "fieldset");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __Blazor.CADPLIS.WebSite.Pages.User.User.TypeInference.CreateMatTextField_0(__builder2, 13, 14, "UserName", 15, "person", 16, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                , 17, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                , 18, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                , 19, 
#nullable restore
#line 14 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                        currentUser.UserName

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => currentUser.UserName = __value, currentUser.UserName)), 21, () => currentUser.UserName);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __Blazor.CADPLIS.WebSite.Pages.User.User.TypeInference.CreateMatTextField_1(__builder2, 25, 26, "Email", 27, "mail_outline", 28, 
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                , 29, 
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                , 30, 
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                                                          true

#line default
#line hidden
#nullable disable
                , 31, "mail", 32, 
#nullable restore
#line 17 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                        currentUser.Email

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => currentUser.Email = __value, currentUser.Email)), 34, () => currentUser.Email);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "div");
                __Blazor.CADPLIS.WebSite.Pages.User.User.TypeInference.CreateMatCheckbox_2(__builder2, 37, 38, "IsHead", 39, "headcheck", 40, 
#nullable restore
#line 20 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                       currentUser.IsHead

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => currentUser.IsHead = __value, currentUser.IsHead)), 42, () => currentUser.IsHead);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatChipSet>(44);
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
             foreach (var role in roleSelections.OrderBy(x => x.DisplayValue))
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MatBlazor.MatChip>(46);
                    __builder3.AddAttribute(47, "Label", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                 role.DisplayValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "LeadingIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                   (role.Selected) ? "done" : ""

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                               ()=>UpdateUserRole(role)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 25 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                                                                                                            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n            Group\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatTreeView<GroupInfoDto>>(54);
                __builder2.AddAttribute(55, "RootNode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GroupInfoDto>(
#nullable restore
#line 30 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                    groupTree

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "GetChildNodesCallback", new MatBlazor.GetChildNodesDelegate<GroupInfoDto>(
#nullable restore
#line 32 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                  (n)=>n.Chilrens

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Class", "gtree");
                __builder2.AddAttribute(58, "SelectedNode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<GroupInfoDto>(
#nullable restore
#line 31 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                              SelectedParentNode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "SelectedNodeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<GroupInfoDto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<GroupInfoDto>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedParentNode = __value, SelectedParentNode))));
                __builder2.AddAttribute(60, "NodeTemplate", (Microsoft.AspNetCore.Components.RenderFragment<GroupInfoDto>)((con) => (__builder3) => {
                    __builder3.AddContent(61, 
#nullable restore
#line 34 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                     con.GroupName

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "mat-layout-grid mat-layout-grid-align-right");
                __builder2.AddAttribute(65, "style", "max-width: 800px;");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "mat-layout-grid-inner");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "mat-layout-grid-cell");
                __builder2.OpenComponent<MatBlazor.MatButton>(70);
                __builder2.AddAttribute(71, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                                     CancelChanges

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(74, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatButton>(76);
                __builder2.AddAttribute(77, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Project\CAD\SourceCode\CADPLIS2021\CAD-PLIS\CADPLIS.WebSite\Pages\User\User.razor"
                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "Type", "submit");
                __builder2.AddAttribute(79, "form", "updateUserForm");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, "Update");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.CADPLIS.WebSite.Pages.User.User
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Icon", __arg1);
        __builder.AddAttribute(__seq2, "IconTrailing", __arg2);
        __builder.AddAttribute(__seq3, "FullWidth", __arg3);
        __builder.AddAttribute(__seq4, "Required", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Icon", __arg1);
        __builder.AddAttribute(__seq2, "IconTrailing", __arg2);
        __builder.AddAttribute(__seq3, "FullWidth", __arg3);
        __builder.AddAttribute(__seq4, "Required", __arg4);
        __builder.AddAttribute(__seq5, "Type", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMatCheckbox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
