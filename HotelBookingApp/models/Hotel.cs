using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelType { get; set; }
        public int HotelRent { get; set; }
        public string HotelAddress { get; set; }
    }
}