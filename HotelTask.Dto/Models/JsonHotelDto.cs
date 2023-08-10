using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask.Dto.Models
{
    public class JsonAvailableRooms
    {
        public object AvailableRoom { get; set; }
    }

    public class JsonRoom
    {

        public string RoomCode { get; set; }

        public string RoomName { get; set; }

        public int Occupancy { get; set; }

        public string Status { get; set; }
        public decimal Price { get; set; }

    }



    public class JsonAvaliabilitiesResponse
    {
        public JsonHotels Hotels { get; set; }
    }

    public class JsonHotelDto
    {
        public string HotelCode { get; set; }
        public string HotelsName { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public decimal LowestPrice { get; set; }
        public string Currency { get; set; }
        public string IsReady { get; set; }
        public JsonAvailableRooms AvailableRooms { get; set; }
    }

    public class JsonHotels
    {
        public List<JsonHotelDto> Hotel { get; set; }
    }

    public class JsonRoot
    {
        public JsonAvaliabilitiesResponse avaliabilitiesResponse { get; set; }
    }


}
