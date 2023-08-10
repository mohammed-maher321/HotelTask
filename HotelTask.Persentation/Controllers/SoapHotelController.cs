using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServiceReference1;

namespace HotelTask.Persentation.Controllers
{
    public class SoapHotelController : Controller
    {
        SoapHotelServiceClient _soapHotelServiceClient;
        private readonly ILogger<SoapHotelController> _logger;

        public SoapHotelController(ILogger<SoapHotelController> logger)
        {
            _logger = logger;
            _soapHotelServiceClient = new SoapHotelServiceClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> HotelList()
        {
            var result = await _soapHotelServiceClient.GetAllHotelsAsync(new ServiceReference1.HotelQueryModel());
            return View(result);
        }

        public IActionResult SearchHotel()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchHotel(ServiceReference1.HotelQueryModel model)
        {
            var result = await _soapHotelServiceClient.GetAllHotelsAsync(model);
            return View("HotelList", result);
        }

    }
}
