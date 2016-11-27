namespace CyberSolution.YandexMetrika.BAL
{
    using Interfaces;
    using CyberSolution.YandexMetrika.DAL;

    public interface IBussinessContext: ICounterContext
    {
        DataContext DataContext { get; }

        ICounterContext CounterContext { get; }

    }
}