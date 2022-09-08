using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.User.UserRole
{
    public partial class UserRoleView
    {
        UserRoleDto userRoleModel { get; set; } = new();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] HttpClient httpClient { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        List<SelectItem<string>> roleList { get; set; } = new();


        protected override async Task OnInitializedAsync()
        {
            await GetRole();
            if (Id != 0)
            {
                await GetById(Id);
                await DisplayRole(userRoleModel.UserId);
            }
            await base.OnInitializedAsync();
        }
        async Task GetById(int id)
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<UserRoleDto>>(string.Format("api/UserRole/Get/{0}", id));
            if (res.IsSuccessStatusCode)
            {
                userRoleModel = res.Result;
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }
        async Task GetRole()
        {
            var res = await httpClient.GetJsonAsync<ApiResponse<List<RoleInfoDto>>>(string.Format("api/Role/GetAllRole"));
            if (res.IsSuccessStatusCode)
            {
                roleList = res.Result.Select(i => new SelectItem<string>
                {
                    Id = i.RoleId,
                    DisplayValue = i.RoleDescription,
                    Selected = userRoleModel.RoleId != null && userRoleModel.RoleId.Equals(i.RoleId)
                }).ToList();
            }
            else
            {
                Error.ShowError(res.Message);
            }
        }
        protected async Task DisplayRole(string userID)
        {
            try
            {
                if (!string.IsNullOrEmpty(userID))
                {
                    userRoleModel.UserId = userID;
                    var res = await httpClient.GetJsonAsync<ApiResponse<List<string>>>($"api/UserRole/GetRoleByUserId?userId={userID}");
                    if (res.IsSuccessStatusCode)
                    {
                        roleList = roleList.Select(i => new SelectItem<string>
                        {
                            Id = i.Id,
                            DisplayValue = i.DisplayValue,
                            Selected = res.Result.Contains(i.Id)
                        }).ToList();
                    }
                    else
                    {
                        Error.ShowError(res.Message);
                    }
                }
                else
                    userID = userRoleModel.UserId;
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
            }

        }
        void Close()
        {
            NavManager.NavigateTo("/User/UserRole/UserRoleList");
        }

    }
}
