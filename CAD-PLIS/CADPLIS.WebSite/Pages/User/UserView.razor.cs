using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using CADPLIS.Domain.CodeLists;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.User
{
    public partial class UserView
    {
        UserDto currentUser { get; set; } = new();
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        string getUserUrl = "api/User/Get/{0}";
        Dictionary<string, string> dicUserType = new();
        Dictionary<string, string> dciState = new();

        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                await GetUserById(Id);
            }
            await SetUserType();
            await SetUserStatus();
            await base.OnInitializedAsync();
        }

        async Task GetUserById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<UserDto>>(string.Format(getUserUrl, id));
            if (res.IsSuccessStatusCode)
            {
                currentUser = res.Result;
            }
        }

        async Task SetUserType()
        {
            var rsp = await GetListByType("UserType");
            var userTypes = rsp.Result;
            foreach (var item in userTypes)
            {
                dicUserType.Add(item.Value, item.Description);
            }
        }
        async Task SetUserStatus()
        {
            var rsp = await GetListByType("ActivationStatus");
            var userTypes = rsp.Result;
            foreach (var item in userTypes)
            {
                dciState.Add(item.Value, item.Description);
            }
        }
        async Task<ApiResponse<List<DropDownList>>> GetListByType(string type)
        {
            string url = $"api/CodeList/GetListByType/{type}";
            var result = await httpRepository.GetJsonAsync<ApiResponse<List<DropDownList>>>(url);
            if (result.IsSuccessStatusCode)
            {
                return result;
            }
            return null;
        }
    }
}
