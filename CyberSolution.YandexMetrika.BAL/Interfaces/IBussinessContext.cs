using System;

namespace CyberSolution.YandexMetrika.BAL
{
    using Interfaces;
    using DAL;

    public interface IBussinessContext: IDisposable,ICounterContext
    {
        DataContext DataContext { get; }

        ICounterContext CounterContext { get; }

    }
}