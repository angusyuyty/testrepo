using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Common;
using CADPLIS.WebSite.HttpClients;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.Group
{
    public partial class GroupView
    {
        GroupDto groupModel { get; set; } = new();
        [CascadingParameter] public MatDialogReference DialogReference { get; set; }
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;

        string getUrl = "api/Group/Get/{0}";
        protected override async Task OnInitializedAsync()
        {
            if (Id != 0)
            {
                await GetById(Id);
            }
            editContext = new(groupModel);
            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<GroupDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                groupModel = res.Result;
            }
        }
        void Back()
        {
            NavManager.NavigateTo("Group/List");
        }
    }
}
