using System.Net.Http;
using System.Net.Http.Headers;

namespace AirStation.Services
{
    public class HttpService : IHttpService
    {
        public HttpClient Client { get; } = new HttpClient();
        public HttpService()
        {
            Client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
