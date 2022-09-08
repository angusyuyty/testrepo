using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.User.UserRole
{
    public partial class UserRoleEdit
    {
        UserRoleDto userRoleModel { get; set; } = new();
        List<UserDto> userList { get; set; } = new();
        List<SelectItem<string>> roleList { get; set; } = new();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        EditContext editContext;

        string getUserUrl = "api/UserRole/Get/{0}";
        string updateUrl = "api/UserRole/Update";

        protected override async Task OnInitializedAsync()
        {
            editContext = new(userRoleModel);
            await GetUser();
            await GetRole();
            if (Id != 0)
            {
                await GetById(Id);
                await DisplayRole(userRoleModel.UserId);
                editContext = new(userRoleModel);
            }

            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<UserRoleDto>>(string.Format(getUserUrl, id));
            if (res.IsSuccessStatusCode)
            {
                userRoleModel = res.Result;
            }
        }
        async Task GetUser()
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<List<UserDto>>>(string.Format("api/User/GetAllUser"));
            if (res.IsSuccessStatusCode)
            {
                userList = res.Result;
            }
        }
        async Task GetRole()
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<List<RoleInfoDto>>>(string.Format("api/Role/GetAllRole"));
            if (res.IsSuccessStatusCode)
            {
                roleList = res.Result.Select(i => new SelectItem<string>
                {
                    Id = i.RoleId,
                    DisplayValue = i.RoleDescription,
                    Selected = userRoleModel.RoleId != null && userRoleModel.RoleId.Equals(i.RoleId)
                }).ToList();
            }
        }

        protected void UpdateUserRole(SelectItem<string> roleSelectionItem)
        {
            roleSelectionItem.Selected = !roleSelectionItem.Selected;

        }
        protected async Task DisplayRole(string userID)
        {

            if (!string.IsNullOrEmpty(userID))
            {
                userRoleModel.UserId = userID;
                var res = await httpRepository.GetJsonAsync<ApiResponse<List<string>>>($"api/UserRole/GetRoleByUserId?userId={userID}");
                if (res.IsSuccessStatusCode)
                {
                    roleList = roleList.Select(i => new SelectItem<string>
                    {
                        Id = i.Id,
                        DisplayValue = i.DisplayValue,
                        Selected = res.Result.Contains(i.Id)
                    }).ToList();
                }
            }
            else
            {
                userID = userRoleModel.UserId;
            }
        }

        async Task SaveData()
        {
            userRoleModel.Roles = roleList.Where(i => i.Selected).Select(i => i.Id).ToList();
            if (editContext.Validate())
            {
                if (userRoleModel.Roles.Count == 0)
                {
                    viewNotifier.Show("the role is required", ViewNotifierType.Error);
                }
                else
                {
                    if (Id == 0)
                    {
                        updateUrl = "api/UserRole/Insert";

                        var result = await httpRepository.PostJsonAsync<ApiResponse>(updateUrl, userRoleModel);
                        if (result.IsSuccessStatusCode)
                        {
                            viewNotifier.Show("success", ViewNotifierType.Success);
                            NavManager.NavigateTo("/User/UserRole/UserRoleList");
                        }
                    }
                    else
                    {
                        var result = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, userRoleModel);
                        if (result.IsSuccessStatusCode)
                        {
                            viewNotifier.Show("success", ViewNotifierType.Success);
                            NavManager.NavigateTo("/User/UserRole/UserRoleList");
                        }
                    }
                }
            }
        }
        void Close()
        {
            NavManager.NavigateTo("/User/UserRole/UserRoleList");
        }
    }
}
