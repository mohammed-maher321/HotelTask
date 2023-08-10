using HotelTask.Dto.Queries;
using HotelTask.Soap.Model;
using System.ServiceModel;

namespace HotelTask.Soap.Interfaces
{
    [ServiceContract]
    public interface ISoapHotelService
    {
        [OperationContract]
        public List<SoapHotelDto> GetAllHotels(HotelQueryModel model);

    }
}
