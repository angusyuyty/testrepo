using CADPLIS.Application.Contracts.ToDoLists;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.ToDoList
{
    public partial class List
    {
        [Inject] HttpRepository httpRepository { get; set; }

        private Paginator<ToDoListDto> paginator = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        private string category { get; set; }
        private string sender { get; set; }
        private int? applicationNo { get; set; }
        private DateTime? startNotificationDate { get; set; }
        private DateTime? endNotificationDate { get; set; }
        private DateTime? startDueDate { get; set; }
        private DateTime? endDueDate { get; set; }
        bool isOpen = false;
        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        async Task GetList()
        {
            var url = $"api/ToDoList/GetPageList/pageSize/{PageSize}/pageIndex/{PageIndex}?category={category}&applicationNo={applicationNo}&sender={sender}&startNotificationDate={startNotificationDate}&endNotificationDate={endNotificationDate}&startDueDate={startDueDate}&endDueDate={endDueDate}";
            var result = await httpRepository.GetJsonAsync<ApiResponse<Paginator<ToDoListDto>>>(url);
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

        async Task Search()
        {
            await GetList();
        }
    }
}
