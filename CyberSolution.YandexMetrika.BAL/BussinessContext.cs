using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CyberSolution.YandexMetrika.BAL.Models;

namespace CyberSolution.YandexMetrika.BAL
{
    using Interfaces;
    using DAL;
    public class BussinessContext: IBussinessContext
    {
        public ICounterContext CounterContext
        {
            get;
        }

        public DataContext DataContext { get; }

        #region implementation IDisposable

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed || !disposing)
                return;

            DataContext?.Dispose();
        }

        #endregion
        public BussinessContext()
        {
            DataContext = new DataContext();
            CounterContext = new CounterContext(DataContext);
        }

        public async Task<List<CounterModel>> GetCountersAsync(string token)
        {
            return await CounterContext.GetCountersAsync(token);

        }
    }
}
