
namespace CyberSolution.YandexMetrika.EasyConnect
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface IProxy
    {
        HttpClient HttpClient { get; }

        #region GET
        Task<TResult> GetAsync<TResult>(string uri) where TResult : class;

        #endregion
    }
}
