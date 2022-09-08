using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.Domain;
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

namespace CADPLIS.WebSite.Pages.User.UserRole
{
    public partial class UserRoleList
    {
        [Inject] HttpClient httpClient { get; set; }
        List<UserDto> userList { get; set; } = new();
        [Inject] NavigationManager NavManager { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }

        [Parameter] public int Id { get; set; } = 0;
        private Paginator<UserRoleDto> paginator = new();
        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        private string userId { get; set; } = "0";
        protected override async Task OnInitializedAsync()
        {
            await GetList();
            await GetUser();
        }

        async Task GetList()
        {
            var url = $"api/UserRole/GetPageList/pageSize/{PageSize}/pageIndex/{PageIndex}?userId={userId}";
            //var url = $"api/User/GetPageUsers/pageSize/{PageSize}/pageIndex/{PageIndex}";
            try
            {
                var result = await httpClient.GetFromJsonAsync<ApiResponse<Paginator<UserRoleDto>>>(url);
                if (result.IsSuccessStatusCode)
                {
                    paginator = result.Result;
                    PageCount = paginator.pageCount;
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
        async Task GetUser()
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<List<UserDto>>>(string.Format("api/User/GetAllUser"));
            if (res.IsSuccessStatusCode)
            {
                userList = res.Result;
            }
            else
            {
                Error.ShowError(res.Message);
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
            NavManager.NavigateTo($"/User/UserRole/Add");
        }
        async Task Search()
        {
            await GetList();

        }
        void Edit(int id)
        {
            Id = id;
            //await OpenDialogFromService("edit");
            NavManager.NavigateTo($"/User/UserRole/Edit/{Id}");
        }

        void View(int id)
        {
            Id = id;
            NavManager.NavigateTo($"/User/UserRole/View/{Id}");
        }
        async Task Delete(int id)
        {
            var boolDelete = await MatDialogService.ConfirmAsync("Are you sure to delete this?");
            if (boolDelete)
            {
                try
                {
                    var result = await httpClient.DeleteAsync<ApiResponse>($"/api/UserRole/Delete/{id}");
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
                catch (Exception ex)
                {
                    Error.ProcessError(ex);
                }

            }
        }
    }
}
