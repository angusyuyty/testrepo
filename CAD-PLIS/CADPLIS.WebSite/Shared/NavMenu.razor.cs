using CADPLIS.Application.Contracts.NavMenus;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Shared
{
    public partial class NavMenu
    {
        protected NavMenuDto navMenuList { get; set; } = new NavMenuDto();
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] AuthenticationStateProvider ApiAuthenticationProvider { get; set; }
        [Inject]IJSRuntime jsRuntime { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await GetNavMenuList();
        }
        async Task GetNavMenuList()
        {
            var c = await ApiAuthenticationProvider.GetAuthenticationStateAsync();
            if (c.User.Identity.IsAuthenticated)
            {
                var rolekey = "role" + c.User.Identity.Name;
                LocalStorageHelper localStorageHelper = new LocalStorageHelper(jsRuntime);
               var role=await localStorageHelper.GetLocalStorage(rolekey);
                if (string.IsNullOrEmpty(role))
                {
                    role = c.User.Claims.Where(u => u.Type == ClaimTypes.Role).FirstOrDefault().Value;
                }
                var data = c.User.Claims.Where(u => u.Type == ClaimTypes.Role).ToList();
                var result = await httpRepository.GetJsonAsync<ApiResponse<NavMenuDto>>("api/NavMenu/GetPermissionMenuWithChilds?role="+role);
                if (result.IsSuccessStatusCode)
                {
                    navMenuList = result.Result;
                }

            }
               
        }
    }
}
