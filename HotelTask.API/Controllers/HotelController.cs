using HotelTask.Application;
using HotelTask.Application.Interfaces;
using HotelTask.Application.Services;
using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static HotelTask.API.Extension.ServiceExtension;

namespace HotelTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ServiceResolver _serviceAccessor;

        private readonly IHotelService _hotelService;

        public HotelController(ServiceResolver serviceAccessor,IHotelService hotelService)
        {
            _serviceAccessor = serviceAccessor;
            _hotelService = hotelService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Get(HotelQueryModel model)
        {
            List<HotelDto> hotels = new List<HotelDto>();
            var readHotelService = _serviceAccessor("Xml");
            var filePath = Directory.GetCurrentDirectory() + "/Files/Xml Hotels Result.xml";
            hotels = readHotelService.ReadHotels(filePath);


            readHotelService = _serviceAccessor("Json");
            filePath = Directory.GetCurrentDirectory() + "/Files/JSON Hotels Result.json";

            hotels.AddRange(readHotelService.ReadHotels(filePath));


            hotels = _hotelService.GetFilterHotels(model, hotels);

       
            return Ok(hotels);

        }
    }
}
