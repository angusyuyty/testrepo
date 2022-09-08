using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.Domain;
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

namespace CADPLIS.WebSite.Pages.GroupAccessibleFunction
{
    public partial class Edit
    {
        GroupAccessibleFunctionDto gfModel { get; set; } = new();
        List<GroupDto> groupList { get; set; } = new();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;
        SelectTree<string> treeModel { get; set; } = new();
        SelectTree<string> seletedItem { get; set; } = new();

        string getUrl = "api/GroupAccessibleFunction/Get/{0}";
        string updateUrl = "api/GroupAccessibleFunction/Update";
        List<string> functions = new();
        protected override async Task OnInitializedAsync()
        {
            editContext = new(gfModel);
            await GetGroup();

            if (Id != 0)
            {
                await GetById(Id);
                await DisplayFunction(gfModel.GroupId);
                editContext = new(gfModel);
            }
            else
            {
                await GetMenu();
            }
            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<GroupAccessibleFunctionDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                gfModel = res.Result;
            }
        }
        async Task GetGroup()
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<List<GroupDto>>>(string.Format("api/Group/GetAllList"));
            if (res.IsSuccessStatusCode)
            {
                groupList = res.Result;
            }
        }
        async Task GetMenu()
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<GetFunctionsDto<string>>>($"/api/GroupAccessibleFunction/GetTree?gId={gfModel.GroupId}");
            if (res.IsSuccessStatusCode)
            {
                treeModel = res.Result.treeModel;
                functions = res.Result.selectedFunctions;
                seletedItem = treeModel.Children.Count > 0 ? treeModel.Children[0] : new SelectTree<string>();
            }
        }

        protected void UpdateFunction(SelectTree<string> selectionItem)
        {
            if (functions.Contains(selectionItem.FId))
            {
                functions.Remove(selectionItem.FId);
            }
            else
            {
                functions.Add(selectionItem.FId);
            }
        }
        protected async Task DisplayFunction(string groupID)
        {

            if (!string.IsNullOrEmpty(groupID))
            {
                gfModel.GroupId = groupID;
                await GetMenu();
            }
            else
            {
                groupID = gfModel.GroupId;
            }
            if (!string.IsNullOrEmpty(groupID))
            {
                var res = await httpRepository.GetJsonAsync<ApiResponse<List<GroupDto>>>($"api/Group/GetAllList?gId={groupID}");
                if (res.IsSuccessStatusCode)
                {
                    gfModel.GroupName = res.Result.FirstOrDefault().GroupDescription;
                }
            }
        }

        async Task SaveData()
        {
            gfModel.Functions = functions;
            if (editContext.Validate())
            {
                if (gfModel.Functions.Count == 0)
                {
                    Error.ShowError("the function is required");
                }
                else
                {
                    if (Id == 0)
                    {
                        updateUrl = "api/GroupAccessibleFunction/Insert";

                        var result = await httpRepository.PostJsonAsync<ApiResponse>(updateUrl, gfModel);
                        if (result.IsSuccessStatusCode)
                        {
                            viewNotifier.Show("success", ViewNotifierType.Success);
                            NavManager.NavigateTo("/GroupAccessibleFunction/List");
                        }
                    }
                    else
                    {
                        var result = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, gfModel);
                        if (result.IsSuccessStatusCode)
                        {
                            viewNotifier.Show("success", ViewNotifierType.Success);
                            NavManager.NavigateTo("/GroupAccessibleFunction/List");
                        }
                    }
                }
            }
        }
        void Close()
        {
            NavManager.NavigateTo("/GroupAccessibleFunction/List");
        }
    }
}
