using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages.FrontEnd
{
    public partial class CreateAccount
    {
        [Inject] public HttpClient HttpClient { get; set; }

        protected Boolean validateInput()
        {
            if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(reEmail) && email == reEmail)
            {
                return true;
            }
            return false;
        }


    }
}
