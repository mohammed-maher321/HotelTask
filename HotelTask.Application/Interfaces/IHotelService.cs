using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;

namespace HotelTask.Application.Interfaces;

public interface IHotelService
{
    public List<HotelDto> GetFilterHotels(HotelQueryModel queryModel, List<HotelDto> hotels);
}
