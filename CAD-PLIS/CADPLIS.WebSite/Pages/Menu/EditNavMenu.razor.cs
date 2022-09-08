using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CADPLIS.WebSite.Shared;
using CADPLIS.WebSite.Notice;

namespace CADPLIS.WebSite.Pages.Menu
{

    public partial class EditNavMenu : ComponentBase
    {
        [Inject] IMatToaster Toaster { get; set; }
        [Inject] HttpClient httpClient { get; set; }

        [CascadingParameter]
        public MatDialogReference DialogReference { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Parameter]
        public string action { get; set; } = "add";
        [Parameter]
        public int Id { get; set; }
        [CascadingParameter]
        public List<NavMenuDto> selectMenus { get; set; } = new List<NavMenuDto>();

        string getByIdUrl = "/api/NavMenu/Get/{0}";
        string editUrl = "/api/NavMenu/Update";
        string addUrl = "/api/NavMenu/Create";
        string getListUrl = "/api/NavMenu/Get";
   
        private NavMenuDto menuTree { get; set; } = new NavMenuDto();
        private NavMenuDto SelectedParentNode { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        NavMenuDto menuDto { get; set; } = new NavMenuDto() { };
        public EditContext editContext;
        //protected override void OnInitialized()
        //{
        //    editContext = new(menuDto);
        //}
        protected override async Task OnInitializedAsync()
        {
            editContext = new(menuDto);
            await GetSubMenuList();
            await GetTreeMenuList();
            if (action == "edit")
            {
                var result = await httpClient.GetFromJsonAsync<ApiResponse<NavMenuDto>>(string.Format(getByIdUrl, Id));
              
                if (result.IsSuccessStatusCode)
                {
                    menuDto = result.Result;
                }
                else
                {
                    Error.ShowError(result.Message);
                }
                GetMenuWithChildren((List<NavMenuDto>)menuTree.Children, menuDto.ParentId.Value);
            }
            
        }

        async Task SaveData()
        {
            if (editContext.Validate())
            {
                if ((SelectedParentNode?.Id).HasValue)
                {
                    menuDto.ParentId = SelectedParentNode?.Id;
                }
                else
                    menuDto.ParentId = null;
                if (action == "edit")
                {
                    if (menuDto.Id.Equals(menuDto.ParentId))
                    {
                        Toaster.Add("A father can't be himself!", MatToastType.Warning, "warning");
                        return;
                    }
                    var result = await httpClient.PutJsonAsync<ApiResponse>(editUrl, menuDto);
                    if (!result.IsSuccessStatusCode)
                    {
                        Error.ShowError(result.Message);
                    }

                }
                else
                {
                    var result = await httpClient.PostJsonAsync<ApiResponse>(addUrl, menuDto);
                    if (!result.IsSuccessStatusCode)
                    {
                        Error.ShowError(result.Message);
                    }
                }

                CloseDialog(true);
            }
        }
        void CloseDialog(bool isSuccess)
        {
            DialogReference.Close(isSuccess);
        }
        async Task GetSubMenuList()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<List<NavMenuDto>>>(getListUrl);
            if (result.IsSuccessStatusCode)
            {
                selectMenus = result.Result;
            }
            else
            {
                Error.ShowError(result.Message);
            }
        }
        async Task GetTreeMenuList()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<NavMenuDto>>("/api/NavMenu/GetWithChild");
            if (result.IsSuccessStatusCode)
            {
                menuTree = result.Result;
            }
            else
            {
                Error.ShowError(result.Message);
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
