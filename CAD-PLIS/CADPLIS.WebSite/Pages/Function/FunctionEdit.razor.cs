using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
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
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Function
{
    public partial class FunctionEdit
    {
        FunctionDto functionModel { get; set; } = new();
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        EditContext editContext;
        bool IsDisabled = false;

        string getUrl = "api/Function/Get/{0}";
        string updateUrl = "api/Function/Update";
        public List<DropDownList> functionTypes { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            editContext = new(functionModel);
            await SetFunctionType();
            if (Id != 0)
            {
                await GetById(Id);
                editContext = new(functionModel);
                IsDisabled = functionModel.SystemFunction ?? Convert.ToBoolean(functionModel.SystemFunction);
            }

            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<FunctionDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                functionModel = res.Result;
                functionModel.CreatedTimeText = functionModel.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss");
                functionModel.UpdatedTimeText = functionModel.UpdatedTime?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        async Task SaveData()
        {
            if (editContext.Validate())
            {
                if (Id == 0)
                {
                    updateUrl = "api/Function/Insert";
                    var result = await httpRepository.PostJsonAsync<ApiResponse>(updateUrl, functionModel);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/Function/List");
                    }
                }
                else
                {
                    var result = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, functionModel);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/Function/List");
                    }
                }
            }
        }
        void Back()
        {
            NavManager.NavigateTo($"/Function/List");
        }
        async Task SetFunctionType()
        {
            var rsp = await GetListByType("FunctionType");
            functionTypes = rsp.Result;
        }
        async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
        {
            string url = $"api/CodeList/GetListByType/{type}";

            var result = await httpRepository.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
            if (result.IsSuccessStatusCode)
            {
                return result;
            }
            return null;
        }
    }
}
