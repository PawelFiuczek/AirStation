using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public interface IHttpService
    {
        HttpClient Client { get; }
    }
}
