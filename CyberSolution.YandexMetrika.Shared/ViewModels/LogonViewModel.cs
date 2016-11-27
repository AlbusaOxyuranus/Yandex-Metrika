
namespace CyberSolution.YandexMetrika.Shared.ViewModels
{

    using BlackBee.Base;

    public class LogonViewModel:ObservableObject
    {
        public LogonViewModel()
        {
            Email = "softisfuture-seo-monnaanna";// "mr.Prokhorchikda@yandex.ru";
            Password = "1679430528"; //"02061989longman";
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
