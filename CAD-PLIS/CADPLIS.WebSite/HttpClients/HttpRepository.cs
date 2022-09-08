using Blazored.LocalStorage;
using CADPLIS.WebSite.Extension;
using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CADPLIS.Common;

namespace CADPLIS.WebSite.HttpClients
{
    public class HttpRepository : IDisposable
    {

        private readonly HttpClient _httpClient;
        private readonly HttpInterceptorService _interceptor;
        private readonly ILocalStorageService _localStorage;

        public HttpRepository(HttpClient client, HttpInterceptorService interceptor, ILocalStorageService localStorage)
        {
            _httpClient = client;
            _interceptor = interceptor;
            _localStorage = localStorage;
            _interceptor.RegisterEvent();
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }

        public async Task<T> GetJsonAsync<T>(string requestUri)
        {
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            return await _httpClient.GetJsonAsync<T>(requestUri);
        }

        public async Task<T> PostJsonAsync<T>(string requestUri, object content)
        {
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            return await _httpClient.PostJsonAsync<T>(requestUri, content);
        }

        public async Task<T> PutJsonAsync<T>(string requestUri, object content)
        {
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            return await _httpClient.PutJsonAsync<T>(requestUri, content);
        }
        public  async Task<T> DeleteAsync<T>(string requestUri)
        {
            var savedToken = await _localStorage.GetItemAsync<string>("authToken");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
            return await _httpClient.DeleteAsync<T>(requestUri);
        }
    }
}
