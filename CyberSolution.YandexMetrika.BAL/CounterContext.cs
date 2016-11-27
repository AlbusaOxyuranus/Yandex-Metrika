using CyberSolution.YandexMetrika.BAL.Interfaces;
using CyberSolution.YandexMetrika.DAL;

namespace CyberSolution.YandexMetrika.BAL
{
    internal class CounterContext : ICounterContext
    {
        private DataContext dataContext;

        public CounterContext(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}