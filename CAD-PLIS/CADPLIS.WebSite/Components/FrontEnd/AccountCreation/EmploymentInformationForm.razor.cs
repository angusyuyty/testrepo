using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Components.FrontEnd.AccountCreation
{
    public class EmploymentInformationFormModel
    {
        #region UI Element @bind-value
        // UI Element @bind-value START //
        public String EmpStatus { get; set; }
        public String Industry { get; set; }
        public String EmployerName { get; set; }
        public String StaffNumber { get; set; }
        public String EmployedFrom { get; set; }
        // UI Element @bind-value END //
        #endregion UI Element @bind-value
    }
}
