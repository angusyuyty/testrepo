using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Menu
{
    public partial class Detail
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Parameter]public int Id { get; set; }
        [CascadingParameter]
        public List<NavMenuDto> selectMenus { get; set; } = new List<NavMenuDto>();

        string getByIdUrl = "/api/NavMenu/Get/{0}";
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

            var result = await httpRepository.GetJsonAsync<ApiResponse<NavMenuDto>>(string.Format(getByIdUrl, Id));

            if (result.IsSuccessStatusCode)
            {
                menuDto = result.Result;
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
