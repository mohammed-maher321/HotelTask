using HotelTask.Application.Interfaces;
using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;
using HotelTask.Soap.Interfaces;
using HotelTask.Soap.Model;
using static HotelTask.Soap.Extentions.ServiceExtension;

namespace HotelTask.Soap.Services
{
    public class SoapHotelService : ISoapHotelService
    {
        private readonly ServiceResolver _serviceAccessor;

        private readonly IHotelService _hotelService;

        public SoapHotelService(ServiceResolver serviceAccessor, IHotelService hotelService)
        {
            _serviceAccessor = serviceAccessor;
            _hotelService = hotelService;
        }

       
        public List<SoapHotelDto> GetAllHotels(HotelQueryModel model)
        {
            List<HotelDto> hotels = new List<HotelDto>();
            var readHotelService = _serviceAccessor("Xml");
            var filePath = Directory.GetCurrentDirectory() + "/Files/Xml Hotels Result.xml";
            hotels = readHotelService.ReadHotels(filePath);


            readHotelService = _serviceAccessor("Json");
            filePath = Directory.GetCurrentDirectory() + "/Files/JSON Hotels Result.json";

            hotels.AddRange(readHotelService.ReadHotels(filePath));


            hotels = _hotelService.GetFilterHotels(model, hotels);


            return hotels?.Select(s => (SoapHotelDto)s).ToList();

        }
        
    }
}
