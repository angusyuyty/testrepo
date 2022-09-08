using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Components.FrontEnd.AccountCreation
{
    public class LoginCredentialFormModel
    {
        #region UI Element @bind-value
        // UI Element @bind-value START //
        public String LoginId { get; set; }
        public String Password { get; set; }
        public String RePassword { get; set; }
        // UI Element @bind-value END //
        #endregion UI Element @bind-value
    }
}
