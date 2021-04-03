using AirStation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public class DataService : IDataService
    {
        private readonly IHttpService httpService;

        public DataService(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<MeasurementData> GetSensorDataAsync(int sensorId)
        {
            var response = await httpService.Client.GetAsync($"http://api.gios.gov.pl/pjp-api/rest/data/getData/{sensorId}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MeasurementData>(content);
        }
    }
}
