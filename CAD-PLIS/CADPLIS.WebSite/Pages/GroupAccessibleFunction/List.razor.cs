using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.Groups;
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

namespace CADPLIS.WebSite.Pages.GroupAccessibleFunction
{
    public partial class List
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        private Paginator<GroupAccessibleFunctionDto> paginator = new();
        List<GroupDto> groupList { get; set; } = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        private string gId { get; set; } = "0";
        private string gname { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetList();
            await GetGroup();
        }

        async Task GetList()
        {
            var url = $"api/GroupAccessibleFunction/GetPageList/pageSize/{PageSize}/pageIndex/{PageIndex}?gId={gId}&gname={gname}";

            var result = await httpRepository.GetJsonAsync<ApiResponse<Paginator<GroupAccessibleFunctionDto>>>(url);
            if (result.IsSuccessStatusCode)
            {
                paginator = result.Result;
                PageCount = paginator.pageCount;
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
        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await GetList();
        }
        void Add()
        {
            NavManager.NavigateTo($"/GroupAccessibleFunction/Add");
        }
        async Task Search()
        {
            await GetList();
        }
        void Edit(int id)
        {
            Id = id;
            NavManager.NavigateTo($"/GroupAccessibleFunction/Edit/{Id}");
        }

        void View(int id)
        {
            Id = id;
            NavManager.NavigateTo($"/GroupAccessibleFunction/View/{Id}");
        }
        async Task Delete(int id)
        {
            var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
            if (boolDelete)
            {
                var result = await httpRepository.DeleteAsync<ApiResponse>($"/api/GroupAccessibleFunction/Delete/{id}");
                if (result.IsSuccessStatusCode)
                {
                    viewNotifier.Show("success", ViewNotifierType.Success, result.Message);
                    await GetList();
                }
            }
        }
    }
}
