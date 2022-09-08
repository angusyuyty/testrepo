using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Application.Contracts.Auths;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.Common.Accounts;
using CADPLIS.Common.CacheManager;
using CADPLIS.Common.Captcha;
using CADPLIS.Domain.Users;
using Google.Authenticator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly ICacheService _cacheService;
        private readonly Jwtsetting jwtsetting;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRoleAppService _userRoleAppService;
       
        public AccountController(IUserAppService userAppService, ICacheService cacheService, IOptions<Jwtsetting> options, 
            IUserRoleAppService userRoleAppService, IHttpContextAccessor httpContextAccessor)
        {
            _userAppService = userAppService;
            _cacheService = cacheService;
            jwtsetting = options.Value;
            _httpContextAccessor = httpContextAccessor;
            _userRoleAppService = userRoleAppService;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ApiResponse> Login(LoginInput loginInput)
        {
            if (ModelState.IsValid)
            {
                var captchaCode = _cacheService.Get(CacheKeys.CaptchaCode).ToLower();
                if (loginInput.VerificationCode.ToLower() != captchaCode)
                {
                    return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "The verification code is incorrect!"));
                }
                var userInfo = await _userAppService.GetByLoginIdAsync(loginInput.UserName);
                if (userInfo == null)
                {
                    return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "The user not exists!"));
                }
                else
                {
                    if (MD5Encryption.MD5Hash(loginInput.Password) != userInfo.Password)
                    {
                        return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "The password is not incorrect!"));
                    }
                    else if (userInfo.Is2FAEnabled ?? Convert.ToBoolean(userInfo.Is2FAEnabled))
                    {
                        return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, "TwoFaValidate", userInfo));
                    }
                    else
                    {

                        var claims = new List<Claim>
                        {
                           new(ClaimTypes.Name, loginInput.UserName),
                        };
                        List<UserRoleDto> userRolesList = await _userRoleAppService.GetRoleByUserId(loginInput.UserName);
                        foreach (var item in userRolesList)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, item.RoleId));
                        }
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtsetting.Key));
                        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var expiry = DateTime.Now.AddHours(double.Parse(jwtsetting.ExpiryInHours));
                        var token = new JwtSecurityToken(jwtsetting.Issuer, jwtsetting.Audience, claims, expires: expiry, signingCredentials: creds);
                        var tokenText = new JwtSecurityTokenHandler().WriteToken(token);
                        return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, "login success!", tokenText));
                    }
                }
            }
            else
            {
                return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "login error"));
            }
        }
        [HttpPost]
        [Route("TwoFaValidateLogin")]
        public async Task<ApiResponse> TwoFaValidateLogin(LoginInput loginInput)
        {
            if (ModelState.IsValid)
            {
                var userdt = await _userAppService.GetByLoginIdAsync(loginInput.UserName);
                userdt.ValidateCode = loginInput.ValidateCode;
                var res = await ValidateTwoFaCode(userdt);
                if (!res.IsSuccessStatusCode)
                {
                    return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "The code is not incorrect!"));
                }
                else
                {

                    var claims = new List<Claim>
                        {
                           new(ClaimTypes.Name, userdt.UserId),
                        };
                    List<UserRoleDto> userRolesList = await _userRoleAppService.GetRoleByUserId(userdt.UserId);
                    foreach (var item in userRolesList)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, item.RoleId));
                    }
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtsetting.Key));
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var expiry = DateTime.Now.AddHours(double.Parse(jwtsetting.ExpiryInHours));
                    var token = new JwtSecurityToken(jwtsetting.Issuer, jwtsetting.Audience, claims, expires: expiry, signingCredentials: creds);
                    var tokenText = new JwtSecurityTokenHandler().WriteToken(token);
                    return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, "login success!", tokenText));

                }
            }
            else
            {
                return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "login error"));
            }
        }


        [HttpGet]
        [Route("GetCaptchaImg")]
        public async Task<FileContentResult> GetCaptchaImg()
        {
            var captchaCode = await CaptchaService.GenerateCaptchaImageAsync();
            _cacheService.Add(CacheKeys.CaptchaCode, captchaCode.CaptchaCode);
            return File(captchaCode.CaptchaMemoryStream.ToArray(), "image/png");

        }

        [HttpGet]
        [Route("GetTwoFaCode")]

        public async Task<ApiResponse> GetTwoFaCode(string userId)
        {
            UserDto userdt = new UserDto();
            if (User.Identity.IsAuthenticated)
            {
                userdt = await _userAppService.GetByLoginIdAsync(User.Identity.Name);

            }
            else
            { 
                userdt= await _userAppService.GetByLoginIdAsync(userId);
            }
            TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
            var setupInfo = twoFactor.GenerateSetupCode("CadPlisManage", userdt.UserId, TwoFactorKey(userdt), false, 3);
            userdt.SetupCode = setupInfo.ManualEntryKey;
            userdt.BarcodeImageUrl = setupInfo.QrCodeSetupImageUrl;
            return new ApiResponse(StatusCodes.Status200OK, OperResult.Success, userdt);
        }

        private static string TwoFactorKey(UserDto user)
        {
            return $"cadplissecretkey+{user.UserId}";
        }
        [HttpPost]
        [Route("ValidateTwoFaCode")]
        public async Task<ApiResponse> ValidateTwoFaCode(UserDto user)
        {
            if (user != null)
            {
                TwoFactorAuthenticator twoFactor = new TwoFactorAuthenticator();
                bool isValid = twoFactor.ValidateTwoFactorPIN(TwoFactorKey(user), user.ValidateCode);
                if (isValid)
                {
                    user.Is2FAEnabled = true;
                    await _userAppService.Update(user);
                    return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, OperResult.Success));
                }
            }
            return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "Incorrect verification code"));
        }

        [HttpPost]
        [Route("SetCurrentRole")]
        public async Task<ApiResponse> SetCurrentRole()
        {
            var currentRole = _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("CurrentRole", out var role);
            if (currentRole)
            {
                _cacheService.Add(CacheKeys.CurrentRole, role, 8 * 60);
                return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, OperResult.Success));
            }
            else
            {
                return await Task.FromResult(new ApiResponse(StatusCodes.Status400BadRequest, "Incorrect Set CurrentRole"));
            }
        }

        [HttpGet]
        [Route("GetUserIsAuthenticated")]
        public async Task<ApiResponse> GetUserIsAuthenticated()
        {
            var isAuthenticated = User.Identity.IsAuthenticated;
            return await Task.FromResult(new ApiResponse(StatusCodes.Status200OK, OperResult.Success, isAuthenticated));
        }
    }
}
