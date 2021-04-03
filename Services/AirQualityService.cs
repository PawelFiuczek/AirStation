using AirStation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public class AirQualityService : IAirQualityService
    {
        private readonly IHttpService httpService;

        public AirQualityService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<AirQualityIndex> GetAirQualityAsync(int stationId)
        {
        var response = await httpService.Client.GetAsync($"http://api.gios.gov.pl/pjp-api/rest/aqindex/getIndex/{stationId}");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<AirQualityIndex>(content);
        }
    }
}
