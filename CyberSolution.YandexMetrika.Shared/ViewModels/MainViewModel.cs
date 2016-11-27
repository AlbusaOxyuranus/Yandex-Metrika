

namespace CyberSolution.YandexMetrika.Shared.ViewModels
{
    using System;
    using BlackBee.Base;

    public class MainViewModel : ObservableObject, IMain
    {
        public CounterViewModel Counters
        {
            get;set;
        }

        public LogonViewModel Logon
        {
            get; set;
        }
    }
}
