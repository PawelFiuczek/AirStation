using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class TestStandController : Controller
    {
        private readonly IApiService apiService;

        public TestStandController(IApiService apiService)
        {
            this.apiService = apiService;
        }
        public async Task<IActionResult> Details(int stationId)
        {
            var measuringStation = await apiService.GetStationsByIdAsync(stationId);
            var testStands = await apiService.GetTestStandsAsync(stationId);
            var airQuality = await apiService.GetAirQualityAsync(stationId);
            measuringStation.TestStands = testStands;
            measuringStation.AirQualityIndex = airQuality;
            return View(measuringStation);
        }
    }
}
