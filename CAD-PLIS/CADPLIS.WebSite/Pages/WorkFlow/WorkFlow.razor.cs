using CADPLIS.Application.Contracts.Logs;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.Domain.WorkFlows;
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

namespace CADPLIS.WebSite.Pages.WorkFlow
{
    public partial class WorkFlow
    {
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Inject] HttpClient httpClient { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        private Paginator<WorkFlowDocumentDto> paginator = new();
        private List<WorkFlowDocumentDto> workflowData = new();
        [Inject] IMatToaster Toaster { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        [Parameter] public string action { get; set; }
        [Parameter] public Guid Id { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await GetList();

        }
        async Task GetList()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<Paginator<WorkFlowDocumentDto>>>($"api/WorkFlow/GetWorkFlows/pageSize/{PageSize}/pageIndex/{PageIndex}");
            if (result.IsSuccessStatusCode)
            {
                paginator = result.Result;
                PageCount = paginator.pageCount;
                workflowData = paginator.data;

            }
            else
            {
                Error.ShowError(result.Message);
            }
        }


        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await GetList();
        }

        void Edit(Guid id)
        {
            Id = id;
            action = "edit";
            navigationManager.NavigateTo($"/WorkFlow/Edit/{Id}");
        }
        void Add()
        {
            action = "add";
            navigationManager.NavigateTo($"/WorkFlow/Add");
        }

        async Task Delete()
        {
            List<Guid> ids = new List<Guid>();
            //var checkData = workflowData.Where(u => u.IsCheck);
            //foreach (var item in checkData)
            //{
            //    ids.Add(item.Id);
            //}
            if (ids.Count == 0)
            {
                Toaster.Add("No row selected!", MatToastType.Warning, "warning");
                return;
            }
            var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
            if (boolDelete)
            {
                var result = await httpClient.PostJsonAsync<ApiResponse>("api/WorkFlow/DeleteRows", ids.ToArray());
                if (result.IsSuccessStatusCode)
                {
                    viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                    await GetList();
                }
                else
                {
                    Error.ShowError(result.Message);
                }

            }
        }

    }
}
