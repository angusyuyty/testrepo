using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.WebSite.Notice;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CADPLIS.WebSite.Shared;
using CADPLIS.Application.Contracts;
using CADPLIS.Common;

namespace CADPLIS.WebSite.Pages.User
{
    public partial class UserAdd:ComponentBase
    {
        protected RegisterViewModel newUserViewModel { get; set; } = new RegisterViewModel();
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] public HttpClient httpClient { get; set; }
        [Inject] IMatToaster Toaster { get; set; }
        [CascadingParameter] public Error Error { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        [Parameter] public Guid? Id { get; set; }

        string registerUrl = "api/Account/Register";
        string getAllRolesUrl = "api/Account/GetAllRoles";
        bool headcheck = false;
        private GroupInfoDto groupTree { get; set; } = new GroupInfoDto();
        private GroupInfoDto SelectedParentNode { get; set; }
        protected List<SelectItem<Guid>> roleSelections { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
           await GetTreeGroupList();
            await LoadRoles();
        }

        void Cancel()
        {
            CloseDialog(false);
        }

        async Task CreateUserAsync()
        {
            try
            {
                newUserViewModel.GroupId = SelectedParentNode?.Id;
                if (string.IsNullOrEmpty(newUserViewModel.GroupId?.ToString()))
                {
                    Toaster.Add("user group is required!", MatToastType.Warning, "warning");
                    return;
                }
                newUserViewModel.Roles = roleSelections.Where(i => i.Selected).Select(i => i.DisplayValue).ToList();

               var result= await httpClient.PostJsonAsync<ApiResponse>(registerUrl, newUserViewModel);
                if (!result.IsSuccessStatusCode)
                {
                    Error.ShowError(result.Message);
                }
                CloseDialog(true);
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
            }
        }

        void CloseDialog(bool isSuccess)
        {
            DialogReference.Close(isSuccess);
        }
        async Task GetTreeGroupList()
        {
            var result = await httpClient.GetFromJsonAsync<ApiResponse<List<GroupInfoDto>>>("/api/Account/GetGroupWhithChilds");
            if (result.IsSuccessStatusCode)
            {
                groupTree.GroupName = " Top Group";
                groupTree.Chilrens = result.Result;

            }
            else
            {
                Error.ShowError(result.Message);
            }
        }
        protected async Task LoadRoles()
        {
            try
            {
                var res = await httpClient.GetJsonAsync<ApiResponse<List<RoleInfoDto>>>(getAllRolesUrl);
                if (res.IsSuccessStatusCode)
                {
                    roleSelections = res.Result.Select(i => new SelectItem<Guid>
                    {
                        Id = i.Id,
                        DisplayValue = i.Name,
                    }).ToList();
                }
                else
                {
                    Error.ShowError(res.Message);
                }
            }
            catch (Exception ex)
            {
                viewNotifier.Show(ex.GetBaseException().Message, ViewNotifierType.Error, "Operation Failed");
            }
        }
        protected void UpdateUserRole(SelectItem<Guid> roleSelectionItem)
        {
            //if (currentUser.UserName.ToLower() != DefaultUserNames.Administrator || roleSelectionItem.DisplayValue != DefaultRoleNames.Administrator)
            roleSelectionItem.Selected = !roleSelectionItem.Selected;
        }


    }
}
