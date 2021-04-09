using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class DataController : Controller
    {
        private readonly IApiService apiService;

        public DataController(IApiService apiService)
        {
            this.apiService = apiService;
        }
        public async Task<IActionResult> Data(int sensorId, int stationId)
        {
            var data = await apiService.GetSensorDataAsync(sensorId);
            TempData["stationId"] = stationId;
            return View(data);
        }
    }
}
