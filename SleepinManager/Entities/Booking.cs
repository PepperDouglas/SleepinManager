using SleepinManager.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
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


        public virtual Invoice Invoice { get; set; }


        public virtual Room Room { get; set; }

        public virtual Customer Customer { get; set; }

        public Booking() {
        }

        public Booking(DateTime startDate, DateTime endDate, Room room, Customer customer, int bedCount) {
            StartDate = startDate;
            EndDate = endDate;
            ExtraBedCount = bedCount;
            RoomID = room.RoomID;
            CustomerID = customer.CustomerID;
        }

        public override string ToString() {
            return $"{Customer.FirstName} {Customer.SurName}, Cost: {Invoice.Cost} ";
        }

        public string DetailsListString() {
            return $"{StartDate.Date} -> {EndDate.Date}";
        }

        public int bookingCost(int roomSize, int stayDuration, int extraBeds) {
            const int singleSmall = 400;
            const int singleBig = 600;
            const int DoubleSmall = 800;
            const int DoubleBig = 1000;
            
            int totalCost = 0;
            
            switch (roomSize) {
                case 15:
                totalCost = singleSmall * stayDuration; 
                break;
                case 20: 
                totalCost = singleBig * stayDuration;
                break;
                case 25:
                totalCost = DoubleSmall * stayDuration;
                break;
                case 30:
                totalCost = DoubleBig * stayDuration;
                break;
                case 35:
                totalCost = DoubleBig * stayDuration;
                break;
            }
            totalCost += extraBeds * 200;
            return totalCost;
        }
    }
}
