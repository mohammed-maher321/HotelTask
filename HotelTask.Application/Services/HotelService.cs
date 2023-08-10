using HotelTask.Application.Interfaces;
using HotelTask.Dto.Models;
using HotelTask.Dto.Queries;

namespace HotelTask.Application.Services;

public class HotelService : IHotelService
{

    public List<HotelDto> GetFilterHotels(HotelQueryModel queryModel,List<HotelDto> hotels)
    {
        if (queryModel != null)
        {
            if (!string.IsNullOrWhiteSpace(queryModel.KeyWord))
            {
                hotels = hotels.Where(s => s.Code.Contains(queryModel.KeyWord)
                                           || s.Name.Contains(queryModel.KeyWord)
                                           || s.Location.Contains(queryModel.KeyWord)
                                           || s.Rating.Contains(queryModel.KeyWord)
                                           || s.Currency.Contains(queryModel.KeyWord)
                                           || s.Rooms.Where(a => a.Code.Contains(queryModel.KeyWord)).Any()
                                           || s.Rooms.Where(a => a.Name.Contains(queryModel.KeyWord)).Any()
                                           ).ToList();
            }

            if (queryModel.PriceFrom != null)
            {
                hotels = hotels.Where(s => s.LowestPrice >= queryModel.PriceFrom).ToList();
            }

            if (queryModel.PriceTo != null)
            {
                hotels = hotels.Where(s => s.LowestPrice <= queryModel.PriceTo).ToList();
            }
        }

        return hotels;
    }
}
