using CADPLIS.Application.Contracts.Auths;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Auth
{
    public interface IAuthService
    {
        Task<ApiResponse> Login(LoginInput loginInput);
        Task<ApiResponse> TwoFaValidateLogin(LoginInput userdt);
        Task Logout();
    }
}
