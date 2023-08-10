using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;
using HotelTask.Persentation.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace HotelTask.Persentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> HotelList()
        {
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress =   new Uri("https://localhost:7082/")
            };
            var dataAsString = JsonConvert.SerializeObject(new HotelQueryModel());
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync("api/Hotel", content);
            response.EnsureSuccessStatusCode();
            var hotels = JsonConvert.DeserializeObject<List<HotelDto>>(await response.Content.ReadAsStringAsync());
            return View(hotels);
        }

        public IActionResult SearchHotel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchHotel(HotelQueryModel model)
        {
            HttpClient httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7082/")
            };
            var dataAsString = JsonConvert.SerializeObject(model);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await httpClient.PostAsync("api/Hotel", content);
            response.EnsureSuccessStatusCode();
            var hotels = JsonConvert.DeserializeObject<List<HotelDto>>(await response.Content.ReadAsStringAsync());
            return View("HotelList",hotels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}