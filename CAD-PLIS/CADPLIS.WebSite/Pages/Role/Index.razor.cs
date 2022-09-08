using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.Auth;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.Role
{
    public partial class Index
    {
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }

        private Paginator<RoleInfoDto> paginator = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }

        string getPageListUrl = "/api/Role/GetPageList/pageSize/{0}/pageIndex/{1}?roleId={2}&roleName={3}";
        string deleteUrl = "api/role/Delete/{0}";

        protected override async Task OnInitializedAsync()
        {
            await GetRoleList();
            await base.OnInitializedAsync();
        }

        async Task GetRoleList()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<Paginator<RoleInfoDto>>>(string.Format(getPageListUrl, PageSize, PageIndex, RoleId, RoleName));
            if (rsp.IsSuccessStatusCode)
            {
                paginator = rsp.Result;
                PageCount = paginator.pageCount;
            }
        }

        async Task Add()
        {
            navigationManager.NavigateTo("/Role/Add");
            await Task.CompletedTask;
        }

        async Task Detail(int id)
        {
            navigationManager.NavigateTo($"/role/detail/{id}");
            await Task.CompletedTask;
        }

        async Task Edit(int id)
        {
            navigationManager.NavigateTo($"/Role/Edit/{id}");
            await Task.CompletedTask;
        }
        async Task DeleteBefore(int id)
        {
            var confirmStr = "sure  delete this?";
            var isDelete = await MatDialogService.ConfirmAsync(confirmStr);
            if (isDelete)
            {
                await Delete(id);
            }
        }

        async Task Delete(int id)
        {
            var rsp = await httpRepository.DeleteAsync<ApiResponse>(string.Format(deleteUrl, id));
            if (rsp.IsSuccessStatusCode)
            {
                viewNotifier.Show("success", ViewNotifierType.Success, rsp.Message);
                await GetRoleList();
            }
        }

        async Task DoFilter(string roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
            await GetRoleList();
        }

        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await DoFilter(RoleId, RoleName);
        }

    }
}
