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
    }
}
