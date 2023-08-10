using System.Xml.Serialization;

namespace HotelTask.Dto.Models;



[XmlRoot(ElementName = "ROOM")]
public class XmlRoom
{

    [XmlElement(ElementName = "ROOMID")]
    public string RoomId { get; set; }

    [XmlElement(ElementName = "ROOM_NAME")]
    public string RoomName { get; set; }

    [XmlElement(ElementName = "OCCUPANCY")]
    public int Occupancy { get; set; }

    [XmlElement(ElementName = "ROOM_STATUS")]
    public string RoomStatus { get; set; }

    [XmlElement(ElementName = "RULE_TEXT")]
    public string RuleText { get; set; }
}

[XmlRoot(ElementName = "ROOMS")]
public class XmlRooms
{

    [XmlElement(ElementName = "ROOM")]
    public List<XmlRoom> Room { get; set; }
}

[XmlRoot(ElementName = "HOTEL")]
public class XmlHotelDto
{

    [XmlElement(ElementName = "ROOMS")]
    public XmlRooms Rooms { get; set; }

    [XmlAttribute(AttributeName = "HOTEL_ID")]
    public string HotelId { get; set; }

    [XmlAttribute(AttributeName = "HOTEL_NAME")]
    public string HotelName { get; set; }

    [XmlAttribute(AttributeName = "LOCATION")]
    public string Location { get; set; }

    [XmlAttribute(AttributeName = "RATING")]
    public string Rating { get; set; }

    [XmlAttribute(AttributeName = "AVAILABLE")]
    public string Available { get; set; }

    [XmlAttribute(AttributeName = "ISRECOMMENDEDPRODUCT")]
    public int IsRecommendedProduct { get; set; }

    [XmlAttribute(AttributeName = "STARTING_PRICE")]
    public decimal StartingPrice { get; set; }

    [XmlAttribute(AttributeName = "CURRENCY")]
    public string Currency { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "HOTELS")]
public class XmlHotels
{

    [XmlElement(ElementName = "HOTEL")]
    public List<XmlHotelDto> Hotel { get; set; }
}

[XmlRoot(ElementName = "HOTEL_SEARCH_RESPONSE")]
public class HotelSearchResponse
{

    [XmlElement(ElementName = "HOTELS")]
    public XmlHotels Hotels { get; set; }
}

