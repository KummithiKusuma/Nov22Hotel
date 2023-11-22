using HotelBookingApp.Models;
using HotelBookingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HotelBookingApplication.Contexts
{
    public class HotelAppContext : DbContext
    {
        public HotelAppContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        /// Creates User table in database
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Creates Hotel table in database
        /// </summary>
        public DbSet<Hotel> Hotels { get; set; }
        /// <summary>
        /// Creates Room table in database
        /// </summary>
        public DbSet<Room> Rooms { get; set; }
        /// <summary>
        /// Creates the Booking in the database
        /// </summary>
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Booking>()
           .HasOne(e => e.room)
           .WithMany()
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
