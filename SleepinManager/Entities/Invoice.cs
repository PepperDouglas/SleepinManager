using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public DateTime CreatedDate { get; set; }

        public virtual Booking Booking { get; set; }

        public Invoice()
        {
            
        }

        public Invoice(int cost, bool hasBeenPaid, bool hasBeenAnnulled, DateTime createdDate) {
            Cost = cost;
            HasBeenPaid = hasBeenPaid;
            HasBeenAnnulled = hasBeenAnnulled;
            CreatedDate = createdDate;
        }

        public Invoice(int invoiceID, int cost, bool hasBeenPaid, bool hasBeenAnnulled, DateTime createdDate) {
            InvoiceID = invoiceID;
            Cost = cost;
            HasBeenPaid = hasBeenPaid;
            HasBeenAnnulled = hasBeenAnnulled;
            CreatedDate = createdDate;
        }
    }
}
