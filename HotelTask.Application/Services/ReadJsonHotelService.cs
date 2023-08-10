using HotelTask.Application.Interfaces;
using HotelTask.Dto.Models;
using Newtonsoft.Json;

namespace HotelTask.Application.Services;


public class ReadJsonHotelService : IReadHotelService
{
    public List<HotelDto> ReadHotels(string filePath)
    {
        var data = File.ReadAllText(filePath);
        var hotels = JsonConvert.DeserializeObject<JsonRoot>(data);
        return hotels.avaliabilitiesResponse?.Hotels?.Hotel?.Select(s => (HotelDto)s).ToList();
    }
}
