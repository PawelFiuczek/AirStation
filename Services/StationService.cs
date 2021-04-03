using AirStation.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public class StationService : IStationService
    {
        private readonly IHttpService httpService;

        public StationService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<MeasuringStation>> GetStationsAsync()
        {
            var response = await httpService.Client.GetAsync("http://api.gios.gov.pl/pjp-api/rest/station/findAll");
            var content = await response.Content.ReadAsStringAsync();
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
    }
}
