using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Repos
{
    public class RoomRepo
    {
        HotelDbContext _context = new();

        public List<Room> SearchAvailableRooms(DateTime startDate, DateTime endDate, int guests)
        {
            var unavailableRooms = _context.Bookings.Include(b => b.Room).ThenInclude(r => r.RoomType)
                                                    .Where(b => guests > (b.Room.RoomType.RoomSize + b.Room.RoomType.ExtraBeds) || (b.CheckInDate <= endDate && b.CheckOutDate >= startDate))
                                                    .Select(b => b.Room).AsNoTracking().ToList();

            var availableRooms = _context.Rooms.Include(r => r.RoomType).Where(r => !unavailableRooms.Contains(r) && (r.RoomType.RoomSize + r.RoomType.ExtraBeds) >= guests).AsNoTracking().ToList();

            return availableRooms;
        }
    }
}
