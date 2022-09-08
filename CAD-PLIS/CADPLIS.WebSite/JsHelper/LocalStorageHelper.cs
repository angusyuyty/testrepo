using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CADPLIS.WebSite
{
    /// <summary>
    /// Operate the LocalStorage help class
    /// </summary>
    public class LocalStorageHelper
    {
        private readonly IJSRuntime _jsRuntime;
        public LocalStorageHelper(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        /// <summary>
        /// Set the LocalStorage
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async Task SetLocalStorage(string key, string value)
        {
            await _jsRuntime.InvokeVoidAsync("LocalStorageSet", key, value);
        }
        /// <summary>
        /// Get LocalStorage
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<string> GetLocalStorage(string key)
        {
            return await _jsRuntime.InvokeAsync<string>("LocalStorageGet", key);
        }
    }
}
