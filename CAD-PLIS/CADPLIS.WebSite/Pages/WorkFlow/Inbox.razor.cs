using CADPLIS.Application.Contracts.Users;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Common;
using CADPLIS.Domain;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.WorkFlows;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.WorkFlow
{
    public partial class Inbox
    {
        [Inject] HttpClient httpClient { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Inject] AuthenticationStateProvider ApiAuthenticationProvider { get; set; }

        private Paginator<WorkFlowDocumentDto> paginator = new();
        UserDto currentUser { get; set; } = new UserDto();
        [CascadingParameter] public Error Error { get; set; }

        private int PageSize { get; set; } = 10;
        private int PageIndex { get; set; } = 0;
        private int PageCount { get; set; }
        string userId = "";

        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var c = await ApiAuthenticationProvider.GetAuthenticationStateAsync();
            if (c.User.Identity.IsAuthenticated)
            {
                userId = c.User.Identity.Name;
            }
            if (string.IsNullOrEmpty(userId))
            {
                NavManager.NavigateTo("/login");

            }
            else
            {
                await GetList();
            }

        }
        async Task GetList()
        {
            try
            {
                var  result = await httpClient.GetFromJsonAsync<ApiResponse< Paginator <WorkFlowDocumentDto>>>($"api/WorkFlow/GetPageInbox/pageSize/{PageSize}/pageIndex/{PageIndex}");
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
            catch (Exception e)
            { 
            }

        }


        async Task OnPage(MatPaginatorPageEvent e)
        {
            PageSize = e.PageSize;
            PageIndex = e.PageIndex;
            await GetList();
        }
        async Task GetCurrentUser()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<UserDto>>($"/api/User/GetUserByUserId/{userId}");
            if (result.IsSuccessStatusCode)
            {
                currentUser = result.Result;
            }
            else
            {
                Error.ShowError(result.Message);
            }
        }

        async Task ExecuteCommand(Guid Id,string Name)
        {
            var commandModel = new CommandModel
            {
                Id = Id,
                CommandName = Name
            };
            var result=await httpClient.PostJsonAsync<ApiResponse>("api/WorkFlow/ExecuteCommand", commandModel);
            if (!result.IsSuccessStatusCode)
            {
                Error.ShowError(result.Message);
            }
            await GetList();
        }

    }
}
