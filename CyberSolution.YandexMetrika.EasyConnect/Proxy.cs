
namespace CyberSolution.YandexMetrika.EasyConnect
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Proxy: IProxy
    {
        public HttpClient HttpClient { get; private set; }

        public Proxy()
        {
            CreateHandler();
            
        }
        public void CreateHandler(HttpMessageHandler handler = null)
        {
            HttpClient = handler == null ? new HttpClient() { Timeout = new TimeSpan(0, 0, 60) } : new HttpClient(handler);
            HttpClient.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;
        }

        public Task<TResult> GetAsync<TResult>(string uri, string token) where TResult : class
        {
            throw new NotImplementedException();
        }
    }
}
