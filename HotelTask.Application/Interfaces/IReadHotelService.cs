using HotelTask.Dto.Models;

namespace HotelTask.Application.Interfaces;

public interface IReadHotelService
{
    public List<HotelDto> ReadHotels(string filePath);
}
