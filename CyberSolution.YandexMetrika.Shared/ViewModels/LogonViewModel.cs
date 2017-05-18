
namespace CyberSolution.YandexMetrika.Shared.ViewModels
{

    using BlackBee.Toolkit.Base;

    public class LogonViewModel:ObservableObject
    {
        public LogonViewModel()
        {
            Email = "mr.Prokhorchikda@yandex.ru";
            Password = "02061989longman";
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
