using CADPLIS.Application.Contracts;
using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Common;
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

namespace CADPLIS.WebSite.Pages.User
{
    public partial class UserRolesEdit : ComponentBase
    {
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] public HttpClient httpClient { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        string currentRoleName = string.Empty;
        List<SelectItem<string>> permissionsSelections = new();
        [Parameter] public string action { get; set; } = "add";
        [Parameter] public string Id { get; set; }
        [Parameter] public string RoleName { get; set; }
        List<string> allPermission = new();
        bool isCurrentRoleReadOnly;
        string getPermissionsUrl = "api/Account/GetPermissions";
        string getRoleByName = "api/Account/Role/{0}";
        string createRoleUrl = "api/Account/CreateRole";
        string updateRoleUrl = "api/Account/UpdateRole";

        protected async override Task OnInitializedAsync()
        {
            isCurrentRoleReadOnly = !string.IsNullOrEmpty(RoleName);
            allPermission = await httpClient.GetJsonAsync<List<string>>(getPermissionsUrl);
            RoleInfoDto roleReponse = null;
            if (action == "edit")
            {
                var result = await httpClient.GetJsonAsync<ApiResponse<RoleInfoDto> >(string.Format(getRoleByName, RoleName));
                if (result.IsSuccessStatusCode)
                {
                    roleReponse = result.Result;
                }
                else
                {
                    Error.ShowError(result.Message);
                }
            }
            foreach (var name in allPermission)
                permissionsSelections.Add(new SelectItem<string>
                {
                    Id = name,
                    DisplayValue = name,
                    Selected = roleReponse!=null&& roleReponse.Permissions != null && roleReponse.Permissions.Contains(name)
                });
            await base.OnInitializedAsync();
        }


        async Task UpsertRole()
        {
            if (string.IsNullOrWhiteSpace(RoleName))
            {
                viewNotifier.Show("Role Creation Error", ViewNotifierType.Error, "Enter in a Role Name");
                return;
            }

            RoleInfoDto request = new()
            {
                Name = RoleName,
                Permissions = permissionsSelections.Where(i => i.Selected).Select(i => i.Id).ToList()
            };
            if (action == "add")
            {
                var result=await httpClient.PostJsonAsync<ApiResponse>(createRoleUrl, request);
                if (!result.IsSuccessStatusCode)
                {
                    Error.ShowError(result.Message);
                }
            }
            else
            {
                var result = await httpClient.PutJsonAsync<ApiResponse>(updateRoleUrl, request);
                if (!result.IsSuccessStatusCode)
                {
                    Error.ShowError(result.Message);
                }
            }
            CloseDialog(true);
        }

        void CancelUpdate()
        {
            CloseDialog(false);
        }
        void CloseDialog(bool isSuccess)
        {
            DialogReference.Close(isSuccess);
        }
    }
}
