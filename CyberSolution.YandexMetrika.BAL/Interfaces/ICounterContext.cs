using System.Collections.Generic;
using System.Threading.Tasks;
using CyberSolution.YandexMetrika.BAL.Models;

namespace CyberSolution.YandexMetrika.BAL.Interfaces
{
    public interface ICounterContext
    {
        Task<List<CounterModel>> GetCountersAsync(string token);
    }
}