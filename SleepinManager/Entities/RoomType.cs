using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomTypeName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
