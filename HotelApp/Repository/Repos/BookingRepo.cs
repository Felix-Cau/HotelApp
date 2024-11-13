using HotelApp.HelperClasses;
using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Repository.Repos
{
    public class BookingRepo
    {
        HotelDbContext _context = new();

        public void RemoveOverDueBookings()
        {
            var allOverDueBookings = _context.Bookings.Where(b => b.PaymentExpireDate < DateTime.Now).ToList();

            foreach (var booking in allOverDueBookings)
            {
                _context.Remove(booking);
            }

            _context.SaveChanges();
        }

        public void CreateBooking(Customer selectedCustomer, Room selectedRoom, DateTime checkInDate, DateTime checkOutDate, int amountOfGuestsOnBooking, int totalPrice)
        {
            Booking newBooking = new()
            {
                CustomerId = selectedCustomer.CustomerId,
                BookedDate = DateTime.Now,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,
                RoomId = selectedRoom.RoomId,
                Guests = amountOfGuestsOnBooking,
                TotalPrice = totalPrice,
                PaymentExpireDate = DateTime.Now.AddDays(10),
                PaymentStatus = "unpaid"
            };

            _context.Bookings.Add(newBooking);

            _context.SaveChanges();
        }

        public List<Booking> GetBookingsByCustomerName(string textBoxSearchString)
        {
            var bookingList = _context.Bookings.Include(b => b.Customer).Include(b => b.Room).ThenInclude(r => r.RoomType)
                                               .Where(b => b.Customer.FullName.Contains(textBoxSearchString.Trim()))
                                               .AsNoTracking().ToList();
            return bookingList;
        }

        public void UpdateBooking(Booking newBookingInfo)
        {
            var oldBookingInfo = _context.Bookings.Find(newBookingInfo.BookingId);

            _context.Entry(oldBookingInfo).CurrentValues.SetValues(newBookingInfo);

            _context.SaveChanges();
        }

        public void DeleteBooking(Booking newBooking)
        {
            _context.Bookings.Remove(newBooking);
            _context.SaveChanges();
        }
    }
}
