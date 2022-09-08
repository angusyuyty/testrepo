using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CADPLIS.Application.Contracts.Monitorings;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace CADPLIS.WebSite.Pages.Monitoring
{
    public partial class Apilog 
    {
        [Inject] public IMatToaster Toaster { get; set; }
        [Inject] public HttpClient httpClient { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        bool showMore = false;
        private Paginator<AuditInfoDto> auditInfoDtos;

        protected override async Task OnInitializedAsync()
        {
            await GetApiLogList();
            
        }

        async Task GetApiLogList()
        { 
            string apiloglist = $"api/Monitoring/GetWebApiLog/pageSize/{PageSize}/pageIndex/{PageIndex}";
            try
            {
                var result = await httpClient.GetFromJsonAsync<ApiResponse<Paginator<AuditInfoDto>>>(apiloglist);
                if (result.IsSuccessStatusCode)
                {
                    auditInfoDtos = result.Result;
                    PageCount = auditInfoDtos.pageCount;
                }
                else
                {
                    Error.ShowError(result.Message);
                }
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
            }
        }

        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await GetApiLogList();
        }
    }
}
