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
    public partial class EditInvoiceForm : Form
    {
        public int BookingID { get; set; }

        public Booking Booking { get; set; }
        public EditInvoiceForm(int bookingID) {
            InitializeComponent();
            BookingID = bookingID;
            Booking = BookingRepo.GetBooking(BookingID);
            GetDisplayData();
        }

        public void GetDisplayData() {
            labelCustomer.Text = $"Invoice for {Booking.Customer.FirstName} {Booking.Customer.FirstName}";
            textBoxPrice.Text = Booking.Invoice.Cost.ToString();
            checkBoxPayment.Checked = Booking.Invoice.HasBeenPaid;
            checkBoxAnulled.Checked = Booking.Invoice.HasBeenAnnulled;
        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            bool paid = false;
            bool anulled = false;
            if (checkBoxPayment.Checked) {
                paid = true;
            }
            if (checkBoxAnulled.Checked) {
                anulled = true;
            }
            Invoice updatedInvoice = new Invoice(BookingID, int.Parse(textBoxPrice.Text), paid, anulled, Booking.Invoice.CreatedDate);
            InvoiceRepo.UpdateInvoice(updatedInvoice);
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
