

namespace CyberSolution.YandexMetrika.DAL
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CyberSolution.YandexMetrika.DAL.ProxyClasses;
    using CyberSolution.YandexMetrika.EasyConnect;

    public class DataContext : IDataContext
    {
        public string BaseAddress { get; }
        public IProxy Proxy { get; protected set; }

        private readonly string _countersPath;
        public DataContext()
        {
            Proxy = new Proxy();
            BaseAddress = "https://api-metrika.yandex.ru";
            _countersPath = "/management/v1/counters";
        }
        public async Task<List<Counter>> GetListCounterAsync()
        {
            string token = "";
            return await Proxy.GetAsync<List<Counter>>(BaseAddress + _countersPath,token);
        }
    }
}
