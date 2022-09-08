using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.Domain.Shared.NavMenus;
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
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Menu
{
    public partial class MenuOper
    {
        [Inject] IMatToaster Toaster { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Parameter] public int? Id { get; set; }
        [CascadingParameter] public List<NavMenuDto> selectMenus { get; set; } = new List<NavMenuDto>();

        string getByIdUrl = "/api/NavMenu/Get/{0}";
        string editUrl = "/api/NavMenu/Update";
        string addUrl = "/api/NavMenu/Create";
        string getListUrl = "/api/NavMenu/Get";

        private NavMenuDto menuTree { get; set; } = new NavMenuDto();
        private NavMenuDto SelectedParentNode { get; set; }
        NavMenuDto menuDto { get; set; } = new NavMenuDto() { };
        public EditContext editContext;
        protected override async Task OnInitializedAsync()
        {
            editContext = new(menuDto);
            await GetSubMenuList();
            await GetTreeMenuList();
            if (Id.HasValue)
            {
                var result = await httpRepository.GetJsonAsync<ApiResponse<NavMenuDto>>(string.Format(getByIdUrl, Id));

                if (result.IsSuccessStatusCode)
                {
                    menuDto = result.Result;
                    editContext = new(menuDto);
                }
                if (menuDto.ParentId.HasValue)
                {
                    GetMenuWithChildren((List<NavMenuDto>)menuTree.Children, menuDto.ParentId.Value);
                }
                else
                {
                    SelectedParentNode = menuTree;
                }
            }
        }

        async Task SaveData()
        {
            if (editContext.Validate())
            {
                if (SelectedParentNode != null && SelectedParentNode.Id != default)
                {
                    menuDto.ParentId = SelectedParentNode.Id;
                }
                else
                    menuDto.ParentId = null;
                if (Id.HasValue)
                {
                    if (menuDto.Id.Equals(menuDto.ParentId))
                    {
                        Toaster.Add("A father can't be himself!", MatToastType.Warning, "warning");
                        return;
                    }
                    var result = await httpRepository.PutJsonAsync<ApiResponse>(editUrl, menuDto);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success, OperResult.Success);
                        CloseDialog();
                    }
                }
                else
                {
                    var result = await httpRepository.PostJsonAsync<ApiResponse>(addUrl, menuDto);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success, OperResult.Success);
                        CloseDialog();
                    }
                }
            }
        }
        void CloseDialog()
        {
            navigationManager.NavigateTo("/Menu/navmenu");
        }
        async Task GetSubMenuList()
        {
            var result = await httpRepository.GetJsonAsync<ApiResponse<List<NavMenuDto>>>(getListUrl);
            if (result.IsSuccessStatusCode)
            {
                selectMenus = result.Result;
            }
        }
        async Task GetTreeMenuList()
        {
            var result = await httpRepository.GetJsonAsync<ApiResponse<NavMenuDto>>("/api/NavMenu/GetWithChild");
            if (result.IsSuccessStatusCode)
            {
                menuTree = result.Result;
            }
        }
        void GetMenuWithChildren(List<NavMenuDto> parentMenus, int parentId)
        {
            foreach (var item in parentMenus)
            {
                if (item.Id == parentId)
                {
                    SelectedParentNode = item;
                    return;
                }
                else if (item.Children != null)
                {
                    GetMenuWithChildren((List<NavMenuDto>)item.Children, parentId);
                }
            }
        }
    }
}
