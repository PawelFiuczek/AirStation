using AirStation.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public class ApiService : IApiService
    {
        private readonly IHttpService httpService;
        private static string apiUri = "http://api.gios.gov.pl/pjp-api/rest/";

        public ApiService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<MeasuringStation>> GetStationsAsync()
        {
            string content = await GetContentFromApi("station/findAll");
            return JsonConvert.DeserializeObject<List<MeasuringStation>>(content);
        }

        public async Task<List<MeasuringStation>> GetStationsByCityAsync(string cityName)
        {
            var allStations = await GetStationsAsync();
            return allStations.Where(s => s.City.Name == cityName).ToList();
        }

        public async Task<MeasuringStation> GetStationsByIdAsync(int stationId)
        {
            var allStations = await GetStationsAsync();
            return allStations.SingleOrDefault(s => s.Id == stationId);
        }

        public async Task<List<TestStand>> GetTestStandsAsync(int stationId)
        {
            string content = await GetContentFromApi($"station/sensors/{stationId}");
            return JsonConvert.DeserializeObject<List<TestStand>>(content);
        }

        public async Task<MeasurementData> GetSensorDataAsync(int sensorId)
        {
            string content = await GetContentFromApi($"data/getData/{sensorId}");
            return JsonConvert.DeserializeObject<MeasurementData>(content);
        }

        public async Task<AirQualityIndex> GetAirQualityAsync(int stationId)
        {
            string content = await GetContentFromApi($"aqindex/getIndex/{stationId}");
            return JsonConvert.DeserializeObject<AirQualityIndex>(content);
        }

        private async Task<string> GetContentFromApi(string apiEndpoint)
        {
            var response = await httpService.Client.GetAsync(apiUri + apiEndpoint);
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
