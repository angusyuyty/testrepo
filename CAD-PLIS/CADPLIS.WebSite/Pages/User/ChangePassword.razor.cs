using CADPLIS.Application.Contracts.Accounts;
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
    public partial class ChangePassword : ComponentBase
    {
        ChangePasswordViewModel changePasswordViewModel = new();
        [Inject] public HttpClient httpClient { get; set; }
        [Parameter] public Guid UserId { get; set; }
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        string changePwdUrl = "api/Account/ChangePassword";
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        async Task ResetUserPasswordAsync()
        {
            changePasswordViewModel.UserId = UserId;
            await httpClient.PutAsJsonAsync(changePwdUrl, changePasswordViewModel);
            CloseDialog(true);
        }
        void CancelChange()
        {
            CloseDialog(false);
        }
        void CloseDialog(bool isSuccess)
        {
            DialogReference.Close(isSuccess);
        }
    }
}
