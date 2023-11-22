using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public byte[] Password { get; set; }
        public long? Phone { get; set; }
        public byte[] Key { get; set; }
    }
}