using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
using CADPLIS.WebSite.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;

namespace CADPLIS.WebSite.Components.FrontEnd
{
    public partial class RadioButtonInput : ComponentBase
    {
        [Parameter] public String Type { get; set; }
        [Parameter] public EventCallback<String> GetSelectedValue { get; set; }
        [Parameter] public String DefaultSelectedValue { get; set; }
        [Parameter] public String Class { get; set; }
        [Inject] HttpClient HttpClient { get; set; }
        [CascadingParameter] public Error Error { get; set; }

        private List<DropDownList> ddlOpts = new List<DropDownList>();

        private String selectedValue = null;

        protected override async Task OnInitializedAsync()
        {
            if (!String.IsNullOrEmpty(Type))
            {
                await SetDropDownOptions();
            }
            await base.OnInitializedAsync();
        }

        async Task SetDropDownOptions()
        {
            var rsp = await GetListByType(Type);
            ddlOpts = rsp.Result;
        }

        async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
        {
            string url = $"api/CodeList/GetListByType/{type}";
            try
            {
                var result = await HttpClient.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
                if (result.IsSuccessStatusCode)
                {
                    return result;
                }
                else
                {
                    Error.ShowError(result.Message);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
                return null;
            }
            return null;
        }

        private async Task OnSelectedValue(String value)
        {
            selectedValue = value;
            //GetSelectedValue?.Invoke(selectedValue);
            if (GetSelectedValue.HasDelegate)
            {
                await GetSelectedValue.InvokeAsync(value);
            }
        }
    }
}
