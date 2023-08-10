using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask.Dto.Models
{
    public class HotelDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Rating { get; set; }
        public decimal LowestPrice { get; set; }
        public string Currency { get; set; }
        public string IsReady { get; set; }
        public List<RoomDto> Rooms { get; set; }


        #region Convert JsonHotelDto to HotelDto

        public static implicit operator HotelDto(JsonHotelDto model)
        {
            return CreateHotelDto(model);
        }

        private static HotelDto CreateHotelDto(JsonHotelDto model)
        {
            if (model != null)
            {
                HotelDto newHotel = new HotelDto();
                newHotel.Code = model.HotelCode;
                newHotel.Currency = model.Currency;
                newHotel.IsReady = model.IsReady;
                newHotel.LowestPrice = model.LowestPrice;
                newHotel.Location = model.Location;
                newHotel.Rating = model.Rating.ToString();
                newHotel.Name = model.HotelsName;
                newHotel.Rooms = JsonConvert.DeserializeObject<List<JsonRoom>>(JsonConvert.SerializeObject(model.AvailableRooms?.AvailableRoom))?.Select(s => (RoomDto)s).ToList();

                return newHotel;
            }
            return null;
        }
        #endregion


        #region Convert XmlHotelDto to HotelDto

        public static implicit operator HotelDto(XmlHotelDto model)
        {
            return CreateHotelDto(model);
        }

        private static HotelDto CreateHotelDto(XmlHotelDto model)
        {
            if (model != null)
            {
                HotelDto newHotel = new HotelDto();
                newHotel.Code = model.HotelId;
                newHotel.Currency = model.Currency;
                newHotel.IsReady = model.Available;
                newHotel.LowestPrice = model.StartingPrice;
                newHotel.Location = model.Location;
                newHotel.Rating = model.Rating;
                newHotel.Name = model.HotelName;
                newHotel.Rooms = model.Rooms?.Room?.Select(s => (RoomDto)s)?.ToList();

                return newHotel;
            }
            return null;
        }
        #endregion
    }


    public class RoomDto
    {

        public string Code { get; set; }

        public string Name { get; set; }

        public int Occupancy { get; set; }

        public bool Status { get; set; }

        #region Convert JsonRoom to RoomDto

        public static implicit operator RoomDto(JsonRoom model)
        {
            return CreateRoomDto(model);
        }

        private static RoomDto CreateRoomDto(JsonRoom model)
        {
            if (model != null)
            {
                RoomDto newHotel = new RoomDto();
                newHotel.Code = model.RoomCode;
                newHotel.Name = model.RoomName;
                newHotel.Occupancy = model.Occupancy;
                newHotel.Status = model.Status == "true" ? true : false;


                return newHotel;
            }
            return null;
        }
        #endregion

        #region Convert XmlRoom to RoomDto

        public static implicit operator RoomDto(XmlRoom model)
        {
            return CreateRoomDto(model);
        }

        private static RoomDto CreateRoomDto(XmlRoom model)
        {
            if (model != null)
            {
                RoomDto newHotel = new RoomDto();
                newHotel.Code = model.RoomId;
                newHotel.Name = model.RoomName;
                newHotel.Occupancy = model.Occupancy;
                newHotel.Status = model.RoomStatus == "AVAILABLE" ? true : false;


                return newHotel;
            }
            return null;
        }
        #endregion
    }
}
