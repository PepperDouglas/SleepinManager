using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepinManager.Repository
{
    public static class BookingRepo
    {
        //private static ManagerContext _db = new ManagerContext();

        public static void AddBooking(Booking booking) {
            ManagerContext _db = new ManagerContext();
            //VI KAN INTE SPARA NED InvoiceID som en porop till Booking korrekt, men!
            //Booking.bookingID är lika som Invoice.invoiceID

            Invoice setInvoice = _db.Invoices.Add(new Invoice(0, false, false, DateTime.Now));

 
            //booking.InvoiceID = setInvoice.InvoiceID;


            _db.Bookings.Add(booking);
            _db.SaveChanges();
        }

        public static List<Booking> RetrieveBooking(DateTime checkIn, DateTime checkOut) {
            ManagerContext _db = new ManagerContext();
            var bookings = _db.Bookings.Where(booking =>
                (checkIn >= booking.StartDate && checkIn < booking.EndDate) ||
                (checkOut > booking.StartDate && checkOut <= booking.EndDate) ||
                (checkIn <= booking.StartDate && checkOut >= booking.EndDate))
                    .ToList();
            foreach (var booking in bookings) {
                _db.Entry(booking).Reload();
            }

            //MessageBox.Show($"First Name is {bookings.First().Customer.FirstName}");

            return bookings;

        }

        public static Booking GetBooking(int id) {
            ManagerContext _db = new ManagerContext();
            //return 
            var booking = _db.Bookings.Find(id);
            _db.Entry(booking).State = EntityState.Detached;
            booking = _db.Bookings.Find(id);
            return booking;
        }

        public static void UpdateBooking(Booking updatedBooking) {
            ManagerContext _db = new ManagerContext();

            Booking oldBooking = _db.Bookings.Find(updatedBooking.BookingID);
            _db.Entry(oldBooking).CurrentValues.SetValues(updatedBooking);
            _db.SaveChanges();
        }

        public static void DeleteBooking(int bookingID) {
            ManagerContext _db = new ManagerContext();
            //Booking booking = GetBooking(bookingID);
            Booking booking = _db.Bookings.Find(bookingID);
            Invoice invoice = _db.Invoices.Find(bookingID);
            _db.Invoices.Remove(invoice);
            _db.Bookings.Remove(booking);
            _db.SaveChanges();
        }

        public static void DeleteBookingsByAnnulledInvoice() {
            //ManagerContext _db = new ManagerContext();
            List<int> idsOfBookingsToRemove = InvoiceRepo.GetAnnulledInvoiceIDs();
            foreach (int id in idsOfBookingsToRemove) {
                DeleteBooking(id);
            }
            
        }

        public static List<Booking> GetBookingsByCustomerID(int customerID) {
            ManagerContext _db = new ManagerContext();
            List<Booking> bookings = _db.Bookings.Where(b => b.CustomerID == customerID).ToList();
            return bookings;
        }
    }
}
