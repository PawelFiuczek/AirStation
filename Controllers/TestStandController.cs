using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class TestStandController : Controller
    {
        private readonly IHttpService httpService;
        private readonly ITestStandService testStandService;
        private readonly IStationService stationService;
        private readonly IAirQualityService airQualityService;

        public TestStandController(IHttpService httpService,ITestStandService testStandService,
                                    IStationService stationService, IAirQualityService airQualityService)
        {
            this.httpService = httpService;
            this.testStandService = testStandService;
            this.stationService = stationService;
            this.airQualityService = airQualityService;
        }
        public async Task<IActionResult> Details(int stationId)
        {
            var testStands = await testStandService.GetTestStandsAsync(stationId);
            var measuringStation = await stationService.GetStationsByIdAsync(stationId);
            var airQuality = await airQualityService.GetAirQualityAsync(stationId);
            measuringStation.TestStands = testStands;
            measuringStation.AirQualityIndex = airQuality;
            return View(measuringStation);
        }
    }
}
