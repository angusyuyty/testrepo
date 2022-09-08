using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Function
{
    public partial class FunctionList
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        private Paginator<FunctionDto> paginator = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        private string fid { get; set; }
        private string fname { get; set; }
        private string ftype { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        async Task GetList()
        {
            var url = $"api/Function/GetPageList/pageSize/{PageSize}/pageIndex/{PageIndex}?fid={fid}&ftype={ftype}&fname={fname}";
            var result = await httpRepository.GetJsonAsync<ApiResponse<Paginator<FunctionDto>>>(url);
            if (result.IsSuccessStatusCode)
            {
                paginator = result.Result;
                PageCount = paginator.pageCount;
            }
        }
        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await GetList();
        }
        void Add()
        {
            NavManager.NavigateTo($"/Function/Add");
        }
        async Task Search()
        {
            await GetList();

        }
        void Edit(int id)
        {
            Id = id;
            NavManager.NavigateTo($"/Function/Edit/{Id}");
        }

        void View(int id)
        {
            Id = id;
            NavManager.NavigateTo($"/Function/View/{Id}");
        }
        async Task Delete(int id)
        {
            var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
            if (boolDelete)
            {
                var result = await httpRepository.DeleteAsync<ApiResponse>($"/api/Function/Delete/{id}");
                if (result.IsSuccessStatusCode)
                {
                    viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                    await GetList();
                }
            }
        }
    }
}
