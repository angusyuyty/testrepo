using Blazored.SessionStorage;
using CADPLIS.Application.Contracts.NavMenus;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System;
using CADPLIS.WebSite.Shared;
using CADPLIS.WebSite.Notice;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.Menu
{
    public partial class NavMenu : ComponentBase
    {
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        public int MenuType { get; set; }
        public string MenuName { get; set; }
        private Paginator<NavMenuDto> paginator = new();
        public string getListUrl = "/api/NavMenu/Get";
        public string getByIdUrl = "/api/NavMenu/Get/{0}";
        public string editUrl = "/api/NavMenu/Update";
        public string deleteUrl = "/api/NavMenu/Delete/{0}";
        public string getPageListUrl = "/api/NavMenu/GetPageList/pageSize/{0}/pageIndex/{1}?menuType={2}&menuName={3}";
        public string havChildUrl = "api/NavMenu/HaveChild/{0}";
        protected override async Task OnInitializedAsync()
        {
            await GetMenuList();
        }
        async Task Add()
        {
            navigationManager.NavigateTo("/Menu/add");
            await Task.CompletedTask;
        }

        async Task Detail(int id)
        {
            navigationManager.NavigateTo($"/Menu/Detail/{id}");
            await Task.CompletedTask;
        }

        async Task Edit(int id)
        {
            navigationManager.NavigateTo($"/Menu/edit/{id}");
            await Task.CompletedTask;
        }
        async Task GetMenuList()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<Paginator<NavMenuDto>>>(string.Format(getPageListUrl, PageSize, PageIndex, MenuType, MenuName));
            if (rsp.IsSuccessStatusCode)
            {
                paginator = rsp.Result;
                PageCount = paginator.pageCount;
            }
        }

        async Task DeleteBefore(int id)
        {
            var menuInfo = await httpRepository.GetJsonAsync<ApiResponse<bool>>(string.Format(havChildUrl, id));
            var result = menuInfo.Result;
            var confirmStr = "sure  delete this?";
            if (result == true)
            {
                confirmStr = "this menu have children menu,still delete this?";
            }

            var boolDelete = await MatDialogService.ConfirmAsync(confirmStr);
            if (boolDelete)
            {
                await Delete(id);
            }
        }

        async Task Delete(int id)
        {
            var result = await httpRepository.DeleteAsync<ApiResponse>(string.Format(deleteUrl, id));
            if (result.IsSuccessStatusCode)
            {
                viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                await GetMenuList();
            }
        }
        async Task DoFilter(string menuName, int type)
        {
            MenuName = menuName;
            MenuType = type;
            await GetMenuList();
        }

        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await DoFilter(MenuName, MenuType);
        }
    }
}
