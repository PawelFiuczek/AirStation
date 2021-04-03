using AirStation.Models;
using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHttpService httpService;
        private readonly IStationService stationService;

        public HomeController(IHttpService httpService, IStationService stationService)
        {
            this.httpService = httpService;
            this.stationService = stationService;
        }

        public async Task<IActionResult> Index()
        {
            var stations = await stationService.GetStationsByCityAsync("Poznań");
            return View(stations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
