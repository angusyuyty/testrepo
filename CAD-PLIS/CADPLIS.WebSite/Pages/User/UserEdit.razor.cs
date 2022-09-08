using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.User
{
    public partial class UserEdit : ComponentBase
    {
        UserDto currentUser { get; set; }=new();
        protected List<SelectItem<Guid>> roleSelections { get; set; } = new();
        public List<DropDownList> UserTypes { get; set; } = new();
        public List<DropDownList> UserStates { get; set; } = new();
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        [Inject] HttpClient httpClient { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;

        string getUserUrl = "api/User/Get/{0}";
        string updateUserUrl = "api/User/UpdateUser";
        protected override async Task OnInitializedAsync()
        {
            editContext = new(currentUser);
            currentUser.PasswordExpiryDate = DateTime.Now;
            if (Id!=0)
            {
                await GetUserById(Id);
                editContext = new(currentUser);
            }
            await SetUserType();
            await SetUserStatus();
            
            await base.OnInitializedAsync();
        }

        async Task GetUserById(int id)
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<UserDto>>(string.Format(getUserUrl, id));
            if (res.IsSuccessStatusCode)
            {
                currentUser = res.Result;
                currentUser.CreatedTimeText = currentUser.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss");
                currentUser.UpdatedTimeText=currentUser.UpdatedTime?.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }


        async Task SaveData()
        {
            currentUser.PasswordExpiryDate = Convert.ToDateTime(currentUser.PasswordExpiryDate).ToLocalTime();
            if (editContext.Validate())
            {
                if (Id == 0)
                {
                    updateUserUrl = "api/User/Register";

                    var result = await httpClient.PostJsonAsync<ApiResponse>(updateUserUrl, currentUser);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/User/UserInfo");
                    }
                    else
                    {
                        Error.ShowError(result.Message);
                    }
                }
                else
                {
                    var result = await httpClient.PutJsonAsync<ApiResponse>(updateUserUrl, currentUser);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/User/UserInfo");
                    }
                    else
                    {
                        Error.ShowError(result.Message);
                    }
                }
            }
        }
        async Task SetUserType()
        {
            var rsp = await GetListByType("UserType");
             UserTypes = rsp.Result;
            
        }
        async Task SetUserStatus()
        {
            var rsp = await GetListByType("ActivationStatus");
             UserStates = rsp.Result;
        }
        async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
        {
            string url = $"api/CodeList/GetListByType/{type}";
            try
            {
                var result = await httpClient.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
                if (result.IsSuccessStatusCode)
                {
                    return result;
                }
                else
                {
                    Error.ShowError(result.Message);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
                return null;
            }
        }



        void Close()
        {
            NavManager.NavigateTo("/User/UserInfo");
        }



    }
}