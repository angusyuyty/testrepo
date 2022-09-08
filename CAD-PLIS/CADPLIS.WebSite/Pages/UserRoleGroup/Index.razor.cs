using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.UserRoleGroup
{
    public partial class Index
    {
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        private Paginator<UserRoleGroupDto> paginator = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }

        int? Id { get; set; }
        string UserId { get; set; }
        string RoleId { get; set; }

        UserAndRole userAndRole = new();

        string getPageListUrl = "api/UserRoleGroup/GetPageList/pageSize/{0}/pageIndex/{1}?id={2}&userId={3}&roleId={4}";
        string getSearchData = "api/UserRoleGroup/GetSearchData";
        string deleteUrl = "api/UserRoleGroup/Delete/{0}";

        protected override async Task OnInitializedAsync()
        {
            await GetList();
            await GetSearchData();
            await base.OnInitializedAsync();
        }
        async Task Add()
        {
            navigationManager.NavigateTo("UserRoleGroup/add");
            await Task.CompletedTask;
        }
        async Task GetList()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<Paginator<UserRoleGroupDto>>>
                (string.Format(getPageListUrl, PageSize, PageIndex, Id ?? 0, UserId, RoleId));
            if (rsp.IsSuccessStatusCode)
            {
                paginator = rsp.Result;
                PageCount = paginator.pageCount;
            }
        }

        async Task GetSearchData()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<UserAndRole>>(getSearchData);
            if (rsp.IsSuccessStatusCode)
            {
                userAndRole = rsp.Result;
            }
        }

        async Task DoFilter(int? id, string userId, string roleId)
        {
            Id = id;
            UserId = userId;
            RoleId = roleId;
            await GetList();
        }

        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await DoFilter(Id, UserId, RoleId);
        }

        async Task DeleteGroup(int id)
        {
            var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
            if (boolDelete)
            {
                var result = await httpRepository.DeleteAsync<ApiResponse>(string.Format(deleteUrl, id));
                if (result.IsSuccessStatusCode)
                {
                    viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                    await DoFilter(Id, UserId, RoleId);
                }
            }
        }
    }
}
