using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Components.FrontEnd.AccountCreation
{
    public partial class ResidentialAddressForm
    {

    }
    public class ResidentialAddressFormModel
    {
        #region UI Element @bind-value
        // UI Element @bind-value START //
        public String ResAddressFirstLine { get; set; }
        public String ResAddressSecondLine { get; set; }
        public String ResAddressThirdLine { get; set; }
        public String ResCountry { get; set; }
        public String PostalAddressFirstLine { get; set; }
        public String PostalAddressSecondLine { get; set; }
        public String PostalAddressThirdLine { get; set; }
        public String PostalCountry { get; set; }
        // UI Element @bind-value END //
        #endregion UI Element @bind-value
    }
}
