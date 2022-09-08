using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common;
using CADPLIS.Domain;
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
    public partial class View
    {
        GroupAccessibleFunctionDto gfModel { get; set; } = new();
        List<GroupDto> groupList { get; set; } = new();
        List<SelectItem<string>> functionList { get; set; } = new();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        [Inject] HttpClient httpClient { get; set; }
        [Inject] IMatToaster Toaster { get; set; }

        [Inject] NavigationManager NavManager { get; set; }

        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;

        string getUrl = "api/GroupAccessibleFunction/Get/{0}";

        protected override async Task OnInitializedAsync()
        {
            editContext = new(gfModel);
            await GetGroup();
            await GetFunction();
            if (Id != 0)
            {
                await GetById(Id);
                await DisplayFunction(gfModel.GroupId);
                editContext = new(gfModel);
            }
            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<GroupAccessibleFunctionDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                gfModel = res.Result;
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }
        async Task GetGroup()
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<List<GroupDto>>>(string.Format("api/Group/GetAllList"));
            if (res.IsSuccessStatusCode)
            {
                groupList = res.Result;
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }
        async Task GetFunction()
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<List<FunctionDto>>>(string.Format("api/Function/GetFunction"));
            if (res.IsSuccessStatusCode)
            {
                functionList = res.Result.Select(i => new SelectItem<string>
                {
                    Id = i.FunctionId,
                    DisplayValue = i.FunctionType + "/" + i.FunctionDescription,
                    Selected = gfModel.FunctionId != null && gfModel.FunctionId.Equals(i.FunctionId)
                }).ToList();
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }

        protected void UpdateFunction(SelectItem<string> selectionItem)
        {
            selectionItem.Selected = !selectionItem.Selected;

        }
        protected async Task DisplayFunction(string groupID)
        {
            try
            {
                if (!string.IsNullOrEmpty(groupID))
                {
                    gfModel.GroupId = groupID;
                    var res = await httpClient.GetJsonAsync<ApiResponse<List<string>>>($"api/GroupAccessibleFunction/GetFunctionByGroupId?gId={groupID}");
                    if (res.IsSuccessStatusCode)
                    {
                        functionList = functionList.Select(i => new SelectItem<string>
                        {
                            Id = i.Id,
                            DisplayValue = i.DisplayValue,
                            Selected = res.Result.Contains(i.Id)
                        }).ToList();
                    }
                    else
                    {
                        Error.ShowError(res.Message);
                    }
                }
                else
                    groupID = gfModel.GroupId;
                if (!string.IsNullOrEmpty(groupID))
                {
                    var res = await httpClient.GetJsonAsync<ApiResponse<List<GroupDto>>>($"api/Group/GetAllList?gId={groupID}");
                    if (res.IsSuccessStatusCode)
                    {
                        gfModel.GroupName = res.Result.FirstOrDefault().GroupDescription;
                    }
                    else
                    {
                        Error.ShowError(res.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
            }

        }


        void Close()
        {
            NavManager.NavigateTo("/GroupAccessibleFunction/List");
        }
    }
}
