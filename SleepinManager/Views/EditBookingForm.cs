using SleepinManager.Entities;
using SleepinManager.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepinManager.Views
{
    public partial class EditBookingForm : Form
    {
        public int BookingID { get; set; }
        public EditBookingForm(int bookingID) {
            InitializeComponent();
            BookingID = bookingID;
            GetDisplayData();
        }

        public void GetDisplayData() { 
            Booking booking = BookingRepo.GetBooking(BookingID);
            dateTimePickerCheckIn.Value = booking.StartDate;
            dateTimePickerCheckOut.Value = booking.EndDate;
            DisplayCheckBoxes(booking.Room);
            List<Booking> list = new List<Booking>();
            foreach (Booking aBooking in booking.Room.Bookings) {
                if (aBooking.BookingID != BookingID) {
                    listBoxUnAvBookings.Items.Add($"{ aBooking.StartDate.ToShortDateString()} -> { aBooking.EndDate.ToShortDateString()}");    

                }
            }           
        }

        public void buttonUpdate_Click(object sender, EventArgs e) {
            bool unavailable = false;
            for (int i = 0; i < listBoxUnAvBookings.Items.Count; i++) {
                if (dateFormatSplitter(listBoxUnAvBookings.Items[i].ToString(), dateTimePickerCheckIn.Value.Date, dateTimePickerCheckOut.Value.Date)) {
                    unavailable = true;
                }
            }
            if (unavailable) {
                MessageBox.Show("Dates are unavailable!");
                return;
            }
            int extraBeds;
            extraBeds = checkBoxBookSingle.Checked == true ? 1 : checkBoxBookDouble.Checked == true ? 2 : 0;
            Booking bookingToUpdate = BookingRepo.GetBooking(BookingID);
            bookingToUpdate.StartDate = dateTimePickerCheckIn.Value;
            bookingToUpdate.EndDate = dateTimePickerCheckOut.Value;
            bookingToUpdate.ExtraBedCount = extraBeds;
            BookingRepo.UpdateBooking(bookingToUpdate);
            this.Close();
        }

        private bool dateFormatSplitter(string datestring, DateTime checkin, DateTime checkout) {
            string[] delimiter = { " -> " };
            string[] dates = datestring.Split(delimiter, System.StringSplitOptions.RemoveEmptyEntries);
            DateTime start = new DateTime(int.Parse(dates[0].Split('-')[0]), int.Parse(dates[0].Split('-')[1]), int.Parse(dates[0].Split('-')[2]));
            DateTime end = new DateTime(int.Parse(dates[1].Split('-')[0]), int.Parse(dates[1].Split('-')[1]), int.Parse(dates[1].Split('-')[2]));
            if ((checkin < start.Date && checkout <= start.Date) || 
                (checkin >= end.Date && checkout > start.Date)) { 
                return false;
            }
            return true;
        }
        private void DisplayCheckBoxes(Room room) {
            checkBoxBookSingle.Checked = false;
            checkBoxBookDouble.Checked = false;
            checkBoxBookSingle.Visible = false;
            checkBoxBookDouble.Visible = false;
            if (room.RoomType.RoomTypeID == 2) {
                checkBoxBookSingle.Visible = true;
            }
            if (room.RoomSize >= 30) {
                checkBoxBookDouble.Visible = true;
            }
        }

        private void checkBoxBookSingle_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxBookDouble.Checked && checkBoxBookSingle.Checked) {
                checkBoxBookDouble.Checked = false;
            }
        }

        private void checkBoxBookDouble_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxBookDouble.Checked && checkBoxBookSingle.Checked) {
                checkBoxBookSingle.Checked = false;
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
