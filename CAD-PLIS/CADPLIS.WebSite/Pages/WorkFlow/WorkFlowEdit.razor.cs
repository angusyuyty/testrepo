using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.WorkFlows;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.WorkFlow
{
    public partial class WorkFlowEdit
    {
        UserDto currentUser = new UserDto();
        List<UserDto> manager { get; set; } = new List<UserDto>();
        [Inject] HttpClient httpClient { get; set; }
        [Inject] AuthenticationStateProvider ApiAuthenticationProvider { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }

        protected WorkFlowDocumentDto workFlowViewModel { get; set; } = new WorkFlowDocumentDto();
        [Parameter] public Guid Id { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;
        string userId = "";
        public List<DropDownList> WorkFlowTypes { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            workFlowViewModel.State = "Vacation request created";
            workFlowViewModel.StateName = "Vacation request created";
            editContext = new(workFlowViewModel);
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
                await GetCurrentUser();
                await GetManager();
                await SetWorkFlowType();
                if (Id!=default)
                {
                    try
                    {
                        var result = await httpClient.GetFromJsonAsync<ApiResponse<WorkFlowDocumentDto>>($"/api/WorkFlow/GetDocument/{Id}");
                        if (result.IsSuccessStatusCode)
                        {
                            workFlowViewModel = result.Result;
                            editContext = new(workFlowViewModel);
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
         
            // await base.OnInitializedAsync();
        }
        void Close()
        {
            NavManager.NavigateTo("/WorkFlow/WorkFlow");
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
        async Task GetManager()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<List<UserDto>>>("/api/User/GetAllUser");
            if (result.IsSuccessStatusCode)
            {
                manager = result.Result;
            }
            else
            {
                Error.ShowError(result.Message);
            }
        }
        async Task CreateWorkFlowAsync()
        {
            workFlowViewModel.AuthorId = currentUser.UserId;
            try
            {
               var result= await httpClient.PostJsonAsync<ApiResponse>("api/WorkFlow/InsertOrUpdate", workFlowViewModel);
                if (!result.IsSuccessStatusCode)
                {
                    Error.ShowError(result.Message);
                }
                else
                {
                    NavManager.NavigateTo("/WorkFlow/WorkFlow");
                }
            }
            catch (Exception e)
            { 
            }
        }
        async Task SetWorkFlowType()
        {
            string url = $"api/CodeList/GetListByType/WorkFlowType";
            try
            {
                var result = await httpClient.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
                if (result.IsSuccessStatusCode)
                {
                    WorkFlowTypes=result.Result;
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
