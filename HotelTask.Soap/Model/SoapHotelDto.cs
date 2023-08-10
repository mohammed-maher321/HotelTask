using HotelTask.Dto.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask.Soap.Model
{
    [DataContract]
    public class SoapHotelDto
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Rating { get; set; }
        [DataMember]
        public decimal LowestPrice { get; set; }
        [DataMember]
        public string Currency { get; set; }
        [DataMember]
        public string IsReady { get; set; }
        [DataMember]
        public List<SoapRoomDto> Rooms { get; set; }


        #region Convert JsonHotelDto to HotelDto

        public static implicit operator SoapHotelDto(HotelDto model)
        {
            return CreateHotelDto(model);
        }

        private static SoapHotelDto CreateHotelDto(HotelDto model)
        {
            if (model != null)
            {
                SoapHotelDto newHotel = new SoapHotelDto();
                newHotel.Code = model.Code;
                newHotel.Currency = model.Currency;
                newHotel.IsReady = model.IsReady;
                newHotel.LowestPrice = model.LowestPrice;
                newHotel.Location = model.Location;
                newHotel.Rating = model.Rating.ToString();
                newHotel.Name = model.Name;
                newHotel.Rooms = model.Rooms?.Select(s => (SoapRoomDto)s).ToList();

                return newHotel;
            }
            return null;
        }
        #endregion


    }

    [DataContract]
    public class SoapRoomDto
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Occupancy { get; set; }
        [DataMember]
        public bool Status { get; set; }

        #region Convert JsonRoom to RoomDto

        public static implicit operator SoapRoomDto(RoomDto model)
        {
            return CreateRoomDto(model);
        }

        private static SoapRoomDto CreateRoomDto(RoomDto model)
        {
            if (model != null)
            {
                SoapRoomDto newHotel = new SoapRoomDto();
                newHotel.Code = model.Code;
                newHotel.Name = model.Name;
                newHotel.Occupancy = model.Occupancy;
                newHotel.Status = model.Status;


                return newHotel;
            }
            return null;
        }
        #endregion


    }
}
