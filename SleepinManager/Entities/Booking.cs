using SleepinManager.Repository;
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

        public int ExtraBedCount { get; set; }

        public int RoomID { get; set; }
        public int CustomerID { get; set; }

        //[ForeignKey("Invoice")]
        //public int? InvoiceID { get; set; }
        //[Required]
        public virtual Invoice Invoice { get; set; }

        //[Required]
        public virtual Room Room { get; set; }
        //[Required]
        public virtual Customer Customer { get; set; }

        public Booking() {
        }

        public Booking(DateTime startDate, DateTime endDate, Room room, Customer customer, int bedCount) {
            StartDate = startDate;
            EndDate = endDate;
            ExtraBedCount = bedCount;
            //Room = room;
            //Customer = customer;
            RoomID = room.RoomID;
            CustomerID = customer.CustomerID;
            //Invoice = new Invoice(0, false, false);
        }

        public override string ToString() {
            //change so that it displays the date or something instead of the name.
            //it the getmethod in bookingrepo doesnt get the updated customer name even though
            //we can see that its set in the database
            return $"{Customer.FirstName} {Customer.SurName}, Cost: {Invoice.Cost} ";
        }

        public string DetailsListString() {
            return $"{StartDate.Date} -> {EndDate.Date}";
        }
    }
}
