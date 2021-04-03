using AirStation.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Services
{
    public class TestStandService : ITestStandService
    {
        private readonly IHttpService httpService;

        public TestStandService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<TestStand>> GetTestStandsAsync(int stationId)
        {
            var response = await httpService.Client.GetAsync($"http://api.gios.gov.pl/pjp-api/rest/station/sensors/{stationId}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<TestStand>>(content);
        }
    }
}

