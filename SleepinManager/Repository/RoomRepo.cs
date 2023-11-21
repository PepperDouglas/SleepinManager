using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Repository
{
    public class RoomRepo
    {

        private readonly ManagerContext _db;

        public RoomRepo() { 
            _db = new ManagerContext();
        }

        public void Insert(Room room) {
            _db.Rooms.Add(room);
            _db.SaveChanges();
        }

        public List<Room> GetAll() {
            return _db.Rooms.ToList();
        }

        public List<Room> GetRoomsByFilters(int roomType, DateTime checkIn, DateTime checkOut) {
            //here we need date filters later
            if (roomType == 0) {
                return _db.Rooms.Where(r => !r.Bookings.Any(booking =>
                (checkIn >= booking.StartDate && checkIn < booking.EndDate) ||
                (checkOut > booking.StartDate && checkOut <= booking.EndDate) ||
                (checkIn <= booking.StartDate && checkOut >= booking.EndDate)))
                    .ToList();
                //return GetAll();
            }
            return _db.Rooms.Where(r => r.RoomType.RoomTypeID == roomType &&
            !r.Bookings.Any(booking =>
                (checkIn >= booking.StartDate && checkIn < booking.EndDate) ||
                (checkOut > booking.StartDate && checkOut <= booking.EndDate) ||
                (checkIn <= booking.StartDate && checkOut >= booking.EndDate)))
                    .ToList();
            //return _db.Rooms.Where(r => ((int)r.RoomType.RoomTypeID) == roomType).ToList();
        }
    }
}
