using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Entities
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Required]
        public int RoomSize { get; set; }
        //[Required]
        //public int ExtraBedCount { get; set; }
        
        [Required]
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        public Room()
        {
            
        }

        public override string ToString() {
            return $"{RoomSize}sqm, {RoomType.RoomTypeName}";
        }
    }
}
