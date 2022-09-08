using CADPLIS.Application.Contracts.Logs;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Log
{
    public partial class DataLogRecord
    {
        [Inject] HttpClient httpClient { get; set; }

        private List<LogRecordDetailDto> logList;
        private string searchValue = "";
        private int pageSize = 5;
        private int pageIndex = 0;
        private int pageCount = 1;
        private Paginator<LogRecordDetailDto> paginator;
        [CascadingParameter] public Error Error { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        async Task GetList()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<Paginator<LogRecordDetailDto>>>($"/api/Monitoring/GetDataLogList/pageSize/{pageSize}/pageIndex/{pageIndex}");
            if (result.IsSuccessStatusCode)
            {
                paginator = result.Result;
                pageCount = paginator.pageCount;
                logList = paginator.data;

            }
            else
            {
                Error.ShowError(result.Message);
            }

        }
        async Task OnPage(MatPaginatorPageEvent e)
        {
            pageSize = e.PageSize;
            pageIndex = e.PageIndex;
            await GetList();
        }


    }
}
