


using System;

namespace CyberSolution.YandexMetrika.DAL
{
    using ProxyClasses;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataContext: IDisposable
    {
        Task<List<Counter>> GetCountersAsync(string token);
    }
}
