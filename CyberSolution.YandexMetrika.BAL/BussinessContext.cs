namespace CyberSolution.YandexMetrika.BAL
{
    using CyberSolution.YandexMetrika.BAL.Interfaces;
    using CyberSolution.YandexMetrika.DAL;
    public class BussinessContext: IBussinessContext
    {
        public ICounterContext CounterContext
        {
            get;
        }

        public DataContext DataContext { get; }

        public BussinessContext()
        {
            DataContext = new DataContext();
            CounterContext = new CounterContext(DataContext);
        }
    }
}
