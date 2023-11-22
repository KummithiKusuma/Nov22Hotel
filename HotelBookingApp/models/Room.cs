using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int Floor { get; set; }
        public string NumberOfPeople { get; set; }
        public int Rating { get; set; }
        public string IsAvailable { get; set; }
    }
}