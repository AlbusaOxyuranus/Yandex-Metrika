
namespace CyberSolution.YandexMetrika.DAL
{
    using CyberSolution.YandexMetrika.DAL.ProxyClasses;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    interface IDataContext
    {
        Task<List<Counter>> GetListCounterAsync();
    }
}
