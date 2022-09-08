using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.UserRoleGroup
{
    public partial class Detail
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter] public string UserId { get; set; }
        [Parameter] public string RoleId { get; set; }
        public string RoleName { get; set; }

        List<SelectItem<string>> groupList { get; set; } = new();
        List<GroupDto> groupDtos = new();
        string getAllGroupUrl = "api/Group/GetAllList";
        string getGroupListUrl = "api/UserRoleGroup/GetList?userId={0}&roleId={1}";

        protected override async Task OnInitializedAsync()
        {
            await GetAllGroup();
            await GetSelectedGroup();
            await base.OnInitializedAsync();
        }

        async Task GetAllGroup()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<List<GroupDto>>>(getAllGroupUrl);
            if (rsp.IsSuccessStatusCode)
            {
                groupDtos = rsp.Result;
            }
        }
        async Task GetSelectedGroup()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<List<UserRoleGroupDto>>>(string.Format(getGroupListUrl, UserId, RoleId));
            if (rsp.IsSuccessStatusCode)
            {
                if (rsp.Result.Any())
                {
                    RoleName = rsp.Result[0].RoleName;
                }
                var selectedGroupIds = rsp.Result.Select(u => u.GroupId);
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
