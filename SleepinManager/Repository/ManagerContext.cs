using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Repository
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("SleepinManagerConnection") { 
            
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}
