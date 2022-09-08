using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Function
{
    public partial class FunctionView
    {
        FunctionDto functionModel { get; set; } = new();
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;

        string getUrl = "api/Function/Get/{0}";
        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                await GetById(Id);
            }
            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<FunctionDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                functionModel = res.Result;
            }
        }
        void Back()
        {
            NavManager.NavigateTo($"/Function/List");
        }
    }
}
