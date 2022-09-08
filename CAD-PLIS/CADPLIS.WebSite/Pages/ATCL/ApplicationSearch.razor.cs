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

namespace CADPLIS.WebSite.Pages.ATCL
{
    public partial class ApplicationSearch
    {
        [Inject] public HttpClient httpClient { get; set; }
        [CascadingParameter] public Error Error { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    await SetFunctionType();
        //    await base.OnInitializedAsync();
        //}

        async Task SetFunctionType()
        {
            var rsp = await GetListByType("ApplicationStatus");
            //applicationStatusOpts = rsp.Result;
        }

        async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
        {
            string url = $"api/CodeList/GetListByType/{type}";
            try
            {
                var result = await httpClient.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
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
        }
    }
}
