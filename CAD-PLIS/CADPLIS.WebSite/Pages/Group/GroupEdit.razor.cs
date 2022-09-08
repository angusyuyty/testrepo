using CADPLIS.Application.Contracts.Groups;
using CADPLIS.WebSite.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using CADPLIS.Common;
using CADPLIS.WebSite.Notice;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Pages.Group
{
    public partial class GroupEdit
    {
        GroupDto groupModel { get; set; } = new();
        [Inject] HttpRepository httpRepository { get; set; }
        [Inject] IViewNotifier viewNotifier { get; set; }
        [Inject] NavigationManager NavManager { get; set; }
        [Parameter] public int Id { get; set; } = 0;
        [CascadingParameter] public Error Error { get; set; }
        EditContext editContext;

        string getUrl = "api/Group/Get/{0}";
        string updateUrl = "api/Group/Update";
        protected override async Task OnInitializedAsync()
        {
            editContext = new(groupModel);
            if (Id != 0)
            {
                await GetById(Id);
                editContext = new(groupModel);
            }
            await base.OnInitializedAsync();
        }

        async Task GetById(int id)
        {
            var res = await httpRepository.GetJsonAsync<ApiResponse<GroupDto>>(string.Format(getUrl, id));
            if (res.IsSuccessStatusCode)
            {
                groupModel = res.Result;
                groupModel.CreatedTimeText = groupModel.CreatedTime.ToString("yyyy-MM-dd HH:mm:ss");
                groupModel.UpdatedTimeText = groupModel.UpdatedTime?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        async Task SaveData()
        {
            if (editContext.Validate())
            {
                if (Id == 0)
                {
                    updateUrl = "api/Group/Insert";

                    var result = await httpRepository.PostJsonAsync<ApiResponse>(updateUrl, groupModel);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/Group/List");
                    }
                }
                else
                {
                    var result = await httpRepository.PutJsonAsync<ApiResponse>(updateUrl, groupModel);
                    if (result.IsSuccessStatusCode)
                    {
                        viewNotifier.Show("success", ViewNotifierType.Success);
                        NavManager.NavigateTo($"/Group/List");
                    }
                }
            }
        }
        void Back()
        {
            NavManager.NavigateTo($"/Group/List");
        }
    }
}
