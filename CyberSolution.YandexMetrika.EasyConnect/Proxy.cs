#define ON_LOG

namespace CyberSolution.YandexMetrika.EasyConnect
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Text;
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
            //HttpClient.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;
        }
        private async Task<TClass> GetObject<TClass>(HttpResponseMessage response, Encoding encoding = null) where TClass : class
        {
            if (response.StatusCode != HttpStatusCode.OK)
                throw new HttpRequestException(response.StatusCode.ToString());

            var stream = await response.Content.ReadAsStreamAsync();

            var responce = new StreamReader(stream, encoding ?? Encoding.UTF8).ReadToEnd();

#if ON_LOG
            Debug.WriteLine(" Dev Windows Phone Log : >> Method ReadObject is stream = " + responce);
#endif
            //Временно
            return default(TClass);
        }
        public async Task<TResult> GetAsync<TResult>(string uri) where TResult : class
        {
#if ON_LOG
            Debug.WriteLine(" Dev Windows Phone Log : >> url =  " + uri);
#endif
            
            var response = await HttpClient.GetAsync(uri);
            var result = await GetObject<TResult>(response);

            return result;
        }

        
    }
}
