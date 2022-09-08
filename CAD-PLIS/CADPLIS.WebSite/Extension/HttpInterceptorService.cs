using CADPLIS.WebSite.Notice;
using Toolbelt.Blazor;
using CADPLIS.Common;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Text.Json;
namespace CADPLIS.WebSite.Extension
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor _interceptor;
        private readonly IViewNotifier _viewNotifier;
        private readonly ILogger<HttpInterceptorService> _logger;
        public HttpInterceptorService(IViewNotifier viewNotifier, HttpClientInterceptor interceptor, ILogger<HttpInterceptorService> logger)
        {
            _viewNotifier = viewNotifier;
            _interceptor = interceptor;
            _logger = logger;
        }
        public void RegisterEvent() => _interceptor.AfterSendAsync += InterceptResponse;
        private async Task InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            var capturedContent = await e.GetCapturedContentAsync();
            var content = await capturedContent.ReadAsStringAsync();
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse<object>>(content);
            if (!response.IsSuccessStatusCode)
            {
                _viewNotifier.Show(response.Message, ViewNotifierType.Error);
            }
        }
        public void DisposeEvent() => _interceptor.AfterSendAsync -= InterceptResponse;
    }
}
