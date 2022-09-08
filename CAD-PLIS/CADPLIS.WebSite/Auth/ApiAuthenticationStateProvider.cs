
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using CADPLIS.Common;
using MatBlazor;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using CADPLIS.WebSite.Extension;
using CADPLIS.WebSite.HttpClients;

namespace CADPLIS.WebSite.Auth
{
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly HttpRepository _httpRepository;
        public ApiAuthenticationStateProvider(HttpClient httpClient, ILocalStorageService localStorage, HttpRepository httpRepository)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _httpRepository = httpRepository;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
           
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");

            if (string.IsNullOrWhiteSpace(savedToken))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            else
            {
                //_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
                // var rsp = await _httpClient.GetJsonAsync<ApiResponse<bool>>("/api/Account/GetUserIsAuthenticated");
                var rsp = await _httpRepository.GetJsonAsync<ApiResponse<bool>>("/api/Account/GetUserIsAuthenticated");
                if (!rsp.IsSuccessStatusCode || rsp.Result == false)
                {
                    return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
                }
            }
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(savedToken), "jwt")));
        }

        public void MarkUserAsAuthenticated(string account)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, account) }, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void MarkUserAsLoggedOut()
        {
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);
        }

        private static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);
            var rolesText = roles.ToString();
            if (rolesText.StartsWith('['))
            {
                var parsedRoles = JsonSerializer.Deserialize<string[]>(rolesText);
                foreach (var parsedRole in parsedRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, rolesText));
            }

            keyValuePairs.Remove(ClaimTypes.Role);

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
