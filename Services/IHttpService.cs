using System.Net.Http;

namespace AirStation.Services
{
    public interface IHttpService
    {
        HttpClient Client { get; }
    }
}
