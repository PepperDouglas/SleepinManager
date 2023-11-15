using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public bool HasBeenPaid { get; set; }
        [Required]
        public bool HasBeenAnnulled { get; set; }


        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
