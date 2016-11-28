using System.Collections.Generic;
using System.Threading.Tasks;
using CyberSolution.YandexMetrika.BAL.Interfaces;
using CyberSolution.YandexMetrika.BAL.Models;
using CyberSolution.YandexMetrika.DAL;
using CyberSolution.YandexMetrika.DAL.ProxyClasses;

namespace CyberSolution.YandexMetrika.BAL
{
    internal class CounterContext : ICounterContext
    {
        private DataContext _dataContext;

        public CounterContext(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<CounterModel>> GetCountersAsync(string token)
        {
            await Task.Delay(3);
            List<Counter> counters =await _dataContext.GetCountersAsync(token);

            List <CounterModel> list=new List<CounterModel>();
            foreach (var counter in counters)
            {
                CounterModel counterModel = new CounterModel()
                {
                    Id=counter.Id,
                    Name=counter.Name,
                    Site=counter.Site,
                    OwnerLogin = counter.OwnerLogin                    
                };
                list.Add(counterModel);
            }
            return list;
        }
    }
}