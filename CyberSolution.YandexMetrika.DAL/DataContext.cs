

using System;

namespace CyberSolution.YandexMetrika.DAL
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProxyClasses;
    using EasyConnect;

    public class DataContext : IDataContext
    {

        #region   implementation IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
        public string BaseAddress { get; }
        public IProxy Proxy { get; protected set; }

        private readonly string _countersPath;
        public DataContext()
        {
            Proxy = new Proxy();
            BaseAddress = "https://api-metrika.yandex.ru";
            _countersPath = "/management/v1/counters";
        }
        public async Task<List<Counter>> GetCountersAsync(string token)
        {
            return await Proxy.GetAsync<List<Counter>>(BaseAddress + _countersPath+ "&oauth_token="+token);
        }
    }
}
