﻿using SleepinManager.Entities;
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
    public partial class CustomerBookingsForm : Form
    {
        public int CustomerID { get; set; }
        public CustomerBookingsForm(int customerID) {
            InitializeComponent();
            CustomerID = customerID;
            GetListData();
        }

        public void GetListData() {
            listBoxBookings.ValueMember = "DetailsListString";
            listBoxBookings.DataSource = BookingRepo.GetBookingsByCustomerID(CustomerID);
        }

        private void ListIndexChanged(object sender, EventArgs e) {
            GetDisplayData((Booking)listBoxBookings.SelectedValue);
        }

        public void GetDisplayData(Booking booking) {
            //Booking booking = BookingRepo.GetBooking(BookingID);
            labelCustomerName.Text = $"Booking for {booking.Customer.FirstName} {booking.Customer.FirstName}";
            labelStartDate.Text = $"Checkin: {booking.StartDate.ToShortDateString()}";
            labelEndDate.Text = $"Checkout: {booking.EndDate.ToShortDateString()}";
            labelPaid.Text = $"Invoice Paid? : ";
            labelPaid.Text += booking.Invoice.HasBeenPaid == true ? "Yes" : "No";
            labelAnnulled.Text = "Invoice annulled? : ";
            labelAnnulled.Text += booking.Invoice.HasBeenAnnulled == true ? "Yes" : "No";
            labelCost.Text = $"Cost: {booking.Invoice.Cost}";
            labelEmail.Text = $"Email: {booking.Customer.Email}";
            labelPhone.Text = $"Phone: {booking.Customer.Telephone}";
            labelRoomSize.Text = $"Roomsize: {booking.Room.RoomSize}";
            labelExtraBeds.Text = $"Extra beds: {booking.ExtraBedCount}";
            labelRoomType.Text = $"Room type: {booking.Room.RoomType.RoomTypeName}";

        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
