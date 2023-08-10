using HotelTask.Application.Interfaces;
using HotelTask.Dto.Models;
using System.Xml.Serialization;

namespace HotelTask.Application.Services;

public class ReadXmlHotelService : IReadHotelService
{

    public List<HotelDto> ReadHotels(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(HotelSearchResponse));
        using (StreamReader reader = new StreamReader(filePath, true))
        {
            var hotels = (HotelSearchResponse)serializer.Deserialize(reader);
            return hotels.Hotels.Hotel.Select(s => (HotelDto)s).ToList();
        }
    }
}

