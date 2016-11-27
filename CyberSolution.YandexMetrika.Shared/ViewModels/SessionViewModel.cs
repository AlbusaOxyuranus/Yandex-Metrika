using BlackBee.Base.DesignPatterns.Creational;

namespace CyberSolution.YandexMetrika.Shared.ViewModels
{
    public class SessionViewModel:Singleton<SessionViewModel>,
        ISession, ISessionMethods, ISessionCommands
    {
        private  SessionViewModel()
        {
            SessionMethods = new SessionLogic();
        }

        public ISessionMethods SessionMethods { get; }

        public string Token { get; set; }
    }
}