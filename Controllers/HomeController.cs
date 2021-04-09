using AirStation.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AirStation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiService apiService;

        public HomeController(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var stations = await apiService.GetStationsByCityAsync("Poznań");
            return View(stations);
        }
    }
}
