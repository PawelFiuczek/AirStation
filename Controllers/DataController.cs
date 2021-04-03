using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class DataController : Controller
    {
        private readonly IHttpService httpService;
        private readonly IDataService dataService;

        public DataController(IHttpService httpService, IDataService dataService)
        {
            this.httpService = httpService;
            this.dataService = dataService;
        }
        public async Task<IActionResult> Data(int sensorId, int stationId)
        {
            var data = await dataService.GetSensorDataAsync(sensorId);
            TempData["stationId"] = stationId;
            return View(data);
        }
    }
}
