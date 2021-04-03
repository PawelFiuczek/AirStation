using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

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
