using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Common;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.Role
{
    public partial class RoleOper
    {
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        [Inject] IViewNotifier viewNotifier { get; set; }
        EditContext editContext;
        RoleInfoDto roleInfoDto = new();
        string getByIdUrl = "api/role/GetById/{0}";
        string createUrl = "api/role/Create";
        string updateUrl = "api/role/Update";
        protected override async Task OnInitializedAsync()
        {
            editContext = new(roleInfoDto);
            if (Id != default(int))
            {
                await GetModel();
            }

            await base.OnInitializedAsync();
        }
        async Task SaveData()
        {
            if (editContext.Validate())
            {
                var rsp = new ApiResponse(StatusCodes.Status200OK, OperResult.Success);
                if (Id == default(int))
                {
                    rsp = await httpRepository.PostJsonAsync<ApiResponse>(createUrl, roleInfoDto);
                }
                else
                {
                    rsp = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, roleInfoDto);
                }
                if (rsp.IsSuccessStatusCode)
                {
                    viewNotifier.Show("success", ViewNotifierType.Success, OperResult.Success);
                    NavManager.NavigateTo("role/index");
                }
            }
        }

        async Task GetModel()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<RoleInfoDto>>(string.Format(getByIdUrl, Id));
            if (rsp.IsSuccessStatusCode)
            {
                roleInfoDto = rsp.Result;
                roleInfoDto.CreatedTimeText = roleInfoDto.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss");
                roleInfoDto.UpdatedTimeText = roleInfoDto.UpdatedTime?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
