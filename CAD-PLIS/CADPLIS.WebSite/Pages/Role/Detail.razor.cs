using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Role
{
    public partial class Detail
    {
        public RoleInfoDto RoleInfoDto { get; set; } = new();
        [Parameter] public int Id { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        public string getByIdUrl = "api/role/GetById/{0}";

        protected override async Task OnInitializedAsync()
        {
            await GetModel();
            await base.OnInitializedAsync();
        }
        async Task GetModel()
        {
            var rsp = await httpRepository.GetJsonAsync<ApiResponse<RoleInfoDto>>(string.Format(getByIdUrl, Id));
            if (rsp.IsSuccessStatusCode)
            {
                RoleInfoDto = rsp.Result;
            }
        }
    }
}
