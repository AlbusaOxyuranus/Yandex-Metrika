namespace CyberSolution.YandexMetrika.Shared.ViewModels
{
    internal interface IMain
    {
        LogonViewModel Logon { get; set; }
        CounterViewModel Counters { get; set; }
    }
}