using CADPLIS.Common;
using CADPLIS.Domain.CodeLists;
using CADPLIS.WebSite.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;

namespace CADPLIS.WebSite.Components.FrontEnd.AccountCreation
{
    public partial class PersonalInformationForm : ComponentBase
    {
        // FunctionEdit.razor.cs
        [Inject] HttpClient HttpClient { get; set; }
        [CascadingParameter] public Error Error { get; set; }
    }
    public class PersonalInformationFormModel
    {
        #region UI Element @bind-value
        // UI Element @bind-value START //
        public String Surname { get; set; }
        public String GivenName { get; set; }
        public String MiddleName { get; set; }
        public String ChiName { get; set; }
        public String Title { get; set; }
        public String Gender { get; set; }
        public DateTime Dob { get; set; }
        public int? ContactNumCountryCode { get; set; }
        public int? ContactNum { get; set; }
        public int? MobileNumCountryCode { get; set; }
        public int? MobileNum { get; set; }
        public String ResHk { get; set; }
        public String Hkid { get; set; }
        public String PassportNumber { get; set; }
        public String IssuingAuthority { get; set; }
        // UI Element @bind-value END //
        #endregion UI Element @bind-value
    }
}
