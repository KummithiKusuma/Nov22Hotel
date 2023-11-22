using System.ComponentModel.DataAnnotations;

namespace HotelBookingApp.Models.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string Username { get; set; }

        public string Email { get; set; }
        public string? Token { get; set; }

        public long? Phone { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; }
    }
}

