using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Entities
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }


        [Required]
        public virtual Room Room { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual Invoice Invoice { get; set; }
    }
}
