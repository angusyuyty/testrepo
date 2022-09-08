using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MatBlazor;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.UserRoleGroup
{
    public partial class Oper
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        List<SelectItem<string>> groupList { get; set; } = new();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Parameter] public int Id { get; set; } = 0;

        string getListUrl = "api/UserRole/GetList";
        string getAllGroupUrl = "api/Group/GetAllList";
        string getByIdUrl = "api/UserRoleGroup/GetById/{0}";
        string getRoleInfoUrl = "api/Role/GetByRoleId/{0}";
        string getGroupListUrl = "api/UserRoleGroup/GetList?userId={0}&roleId={1}";
        string updateUrl = "api/UserRoleGroup/Update";

        List<string> UserIds = new();
        List<UserRoleDto> userRoleDtos = new();
        List<UserRoleDto> userSelectRoleDtos = new();
        List<GroupDto> groupDtos = new();
        EditContext editContext;
        UserRoleDto userRoleDto = new();
        protected override async Task OnInitializedAsync()
        {
            editContext = new(userRoleDto);
            await GetSearchData();
            await GetAllGroup();
            if (Id != default)
            {
                await GetEditData();
            }

            editContext = new(userRoleDto);

            await base.OnInitializedAsync();
        }


        async Task GetSearchData()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<List<UserRoleDto>>>(getListUrl);
            if (rsp.IsSuccessStatusCode)
            {
                var result = rsp.Result;
                userRoleDtos = result;
                UserIds = result.Select(u => u.UserId).Distinct().ToList();
                userSelectRoleDtos = result;
            }
        }

        async Task GetAllGroup()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<List<GroupDto>>>(getAllGroupUrl);
            if (rsp.IsSuccessStatusCode)
            {
                groupDtos = rsp.Result;
            }
        }

        async Task GetEditData()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<UserRoleGroupDto>>(string.Format(getByIdUrl, Id));
            if (rsp.IsSuccessStatusCode)
            {
                var result = rsp.Result;
                userRoleDto.UserId = result.UserId;
                userRoleDto.RoleId = result.RoleId;
                await GetRoleInfo();
                await ChangeUser(result.UserId);
            }
        }

        async Task GetRoleInfo()
        {

            var rsp = await httpRepository.GetJsonAsync<ApiResponse<RoleInfoDto>>(string.Format(getRoleInfoUrl, userRoleDto.RoleId));
            if (rsp.IsSuccessStatusCode)
            {
                userRoleDto.RoleName = rsp.Result.RoleDescription;
            }
        }

        async Task ChangeUser(string userId)
        {
            userRoleDto.UserId = userId;
            var result = userRoleDtos.Where(u => u.UserId.Equals(userId)).ToList();
            if (result.Any())
            {
                userSelectRoleDtos = result.GroupBy(u => new { u.RoleId, u.RoleName })
                    .Select(u => new UserRoleDto
                    {
                        RoleId = u.FirstOrDefault().RoleId,
                        RoleName = u.FirstOrDefault().RoleName
                    }).ToList();

                userRoleDto.RoleId = userSelectRoleDtos.FirstOrDefault().RoleId;
                userRoleDto.RoleName = userSelectRoleDtos.FirstOrDefault().RoleName;
                await GetSelectedGroup();
            }
            else
            {
                userSelectRoleDtos = new List<UserRoleDto>();
            }
        }

        async Task ChangeRole(string roleId)
        {
            userRoleDto.RoleId = roleId;
            var first = userRoleDtos.FirstOrDefault(u => u.UserId == userRoleDto.UserId && u.RoleId == roleId);
            if (first != null)
            {
                userRoleDto.RoleName = first.RoleName;
                await GetSelectedGroup();
            }
            else
            {
                userRoleDto.RoleName = null;
            }
        }

        async Task SaveData()
        {
            var userRoleGroupDto = new UserRoleGroupDto
            {
                UserId = userRoleDto.UserId,
                RoleId = userRoleDto.RoleId,
            };
            userRoleGroupDto.GroupIds = groupList.Where(i => i.Selected).Select(i => i.Id).ToList();

            var rsp = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, userRoleGroupDto);
            if (rsp.IsSuccessStatusCode)
            {
                viewNotifier.Show("success", ViewNotifierType.Success, rsp.Message);
                navigationManager.NavigateTo("/UserRoleGroup/Index");
            }
        }

        protected void UpdateGroup(SelectItem<string> roleSelectionItem)
        {
            roleSelectionItem.Selected = !roleSelectionItem.Selected;
        }
        async Task GetSelectedGroup()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<List<UserRoleGroupDto>>>(string.Format(getGroupListUrl, userRoleDto.UserId, userRoleDto.RoleId));
            if (rsp.IsSuccessStatusCode)
            {
                var selectedGroupIds = new List<string>();
                selectedGroupIds = rsp.Result.Select(u => u.GroupId).ToList();
                groupList = groupDtos.Select(i => new SelectItem<string>
                {
                    Id = i.GroupId,
                    DisplayValue = i.GroupId,
                    Selected = selectedGroupIds.Contains(i.GroupId)
                }).ToList();
            }
        }
    }
}
