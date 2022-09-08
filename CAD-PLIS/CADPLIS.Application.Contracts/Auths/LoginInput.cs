using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.Auths
{
    public class LoginInput
    {
        public string UserName { get; set; }

        public string Password { get; set; }
        public string ValidateCode { get; set; }

        public string VerificationCode {  get; set; }
        public bool RememberMe { get; set; }
    }
}
