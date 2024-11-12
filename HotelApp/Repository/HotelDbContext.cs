using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HotelApp.Repository
{
    public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = ConfigurationManager.ConnectionStrings["HotelAppDB"].ConnectionString;

            optionsBuilder.UseSqlServer(connection);
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomsTypes { get; set; }
    }
}
