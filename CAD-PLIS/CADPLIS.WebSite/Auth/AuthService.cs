
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using CADPLIS.Application.Contracts.Auths;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Common;
using CADPLIS.WebSite.Notice;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Auth
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        [Inject] IViewNotifier viewNotifier { get; set; }
        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<ApiResponse> Login(LoginInput loginInput)
        {
           var rsp = await _httpClient.PostJsonAsync<ApiResponse>("/api/Account/Login", loginInput);
            if (rsp.IsSuccessStatusCode && rsp.Message!= "TwoFaValidate")
            {
                var authToken = rsp.Result.ToString();
                await _localStorage.SetItemAsync("authToken", authToken);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginInput.UserName);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            }
            return rsp;
        }
        public async Task<ApiResponse> TwoFaValidateLogin(LoginInput loginInput)
        {
            var rsp = await _httpClient.PostJsonAsync<ApiResponse>("/api/Account/TwoFaValidateLogin", loginInput);
            if (rsp.IsSuccessStatusCode)
            {
                var authToken = rsp.Result.ToString();
                await _localStorage.SetItemAsync("authToken", authToken);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginInput.UserName);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
            }
            return rsp;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
