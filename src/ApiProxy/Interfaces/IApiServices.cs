using ApiProxy.Models;

namespace ApiProxy.Interfaces
{
    public interface IApiServices
    {
        Wrapper<T> Get<T>(string url) where T : new();
        Wrapper<T> Post<T>(string url, string data) where T : new();
        Wrapper<string> Delete(string url);
    }
}