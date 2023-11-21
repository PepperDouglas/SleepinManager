using SleepinManager.Entities;
using SleepinManager.Repository;
using SleepinManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepinManager
{
    public partial class SManagerForm : Form
    {
        public bool SelectionEnabled { get; set; }
        public SManagerForm() {
            InitializeComponent();

            SelectionEnabled = true;
        }
        private void btnSearchRooms_Click(object sender, EventArgs e) {
            string condition = comboBoxRoomTypes.Text;
            ListRooms(condition, dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
        }

        //This should check bookings with some join to get only available rooms later
        public void ListRooms(string condition, DateTime checkIn, DateTime checkOut) {
            RoomRepo _repo = new RoomRepo();
            listBoxRooms.DisplayMember = "ToString";
            if (condition == "Double Rooms") {
                listBoxRooms.DataSource = _repo.GetRoomsByFilters(2, checkIn, checkOut);
            } else if (condition == "Single Rooms") {
                listBoxRooms.DataSource = _repo.GetRoomsByFilters(1, checkIn, checkOut);
            } else { 
                listBoxRooms.DataSource = _repo.GetRoomsByFilters(0, checkIn, checkOut);
            }

        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e) {
            listBoxCustomers.DisplayMember = "JoinName";
            listBoxCustomers.DataSource = CustomerRepo.GetCustomersByFilter(textBoxCustomerSearch.Text);

        }

        /*
        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectionEnabled) {
                if (listBoxCustomers.SelectedIndex >= 0) {
                    Customer customer = listBoxCustomers.SelectedItem as Customer;
                    if (customer != null) {
                        UpdateDetails(customer);
                    }
                }
            }
        }
        */

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e) {
            checkBox1Bed.Checked = false; 
            checkBox2Bed.Checked = false;
            checkBox1Bed.Visible = false;
            checkBox2Bed.Visible = false;
            if (((Room)listBoxRooms.SelectedItem).RoomType.RoomTypeID == 2) {
                checkBox1Bed.Visible = true;
            }
            if (((Room)listBoxRooms.SelectedItem).RoomSize >= 30) {
                checkBox2Bed.Visible = true;
            } 
        }

        private void checkBox1Bed_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2Bed.Checked && checkBox1Bed.Checked) {
                checkBox2Bed.Checked = false;
            }
        }

        private void checkBox2Bed_CheckedChanged(object sender, EventArgs e) {
            if (checkBox2Bed.Checked && checkBox1Bed.Checked) {
                checkBox1Bed.Checked = false;
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e) {
            //check dates
            if (dateTimePickerCheckIn.Value.Date >= dateTimePickerCheckOut.Value.Date) {
                MessageBox.Show("Checkout must be after Check-in");
                return;
            }
            if (listBoxCustomers.SelectedItem == null) {
                MessageBox.Show("Please select a customer for this booking");
                return;
            }
            if (listBoxRooms.SelectedItem == null) {
                MessageBox.Show("Please select a room for this booking");
                return;
            }
            int extraBeds;
            extraBeds = checkBox1Bed.Checked == true ? 1 : checkBox2Bed.Checked == true ? 2 : 0;
            //Invoice newInvoice = new Invoice(0, false, false);
            //int invoiceID = InvoiceRepo.AddInvoice(newInvoice);
            Booking booking = new Booking(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value,
                (Room)listBoxRooms.SelectedItem, (Customer)listBoxCustomers.SelectedItem, extraBeds);
            BookingRepo.AddBooking(booking);
        }

        private void buttonSearchBooking_Click(object sender, EventArgs e) {

            // Retrieve updated bookings after updating customer
            listBoxBookings.DataSource = null;
            var updatedBookings = BookingRepo.RetrieveBooking(dateTimePickerBookStart.Value, dateTimePickerBookEnd.Value);

            // Set the data source to null to clear existing data

            listBoxBookings.ValueMember = "ToString";
            // Set the data source to the updated bookings
            listBoxBookings.DataSource = updatedBookings;

            // Refresh the ListBox to reflect the changes
            listBoxBookings.Refresh();
        }

        private void buttonRemoveBooking_Click(object sender, EventArgs e) {
            BookingRepo.DeleteBooking(((Booking)listBoxBookings.SelectedItem).BookingID);
        }

        private void buttonShowInvoice_Click(object sender, EventArgs e) {
            if (listBoxBookings.SelectedValue != null) {
                EditInvoiceForm form = new EditInvoiceForm(((Booking)listBoxBookings.SelectedValue).BookingID);
                form.ShowDialog();

            }
        }

        private void buttonShowDetails_Click(object sender, EventArgs e) {
            if (listBoxBookings.SelectedValue != null) {
                BookingDetailsForm form = new BookingDetailsForm(((Booking)listBoxBookings.SelectedValue).BookingID);
                form.ShowDialog();

            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e) {
            if (listBoxBookings.SelectedValue != null) {
                EditBookingForm form = new EditBookingForm(((Booking)listBoxBookings.SelectedValue).BookingID);
                form.ShowDialog();

            }
        }

        private void buttonAnnullExpired_Click(object sender, EventArgs e) {
            InvoiceRepo.AnnullExpired();
        }

        private void buttonRemoveExpired_Click(object sender, EventArgs e) {
            BookingRepo.DeleteBookingsByAnnulledInvoice();
        }

        private void buttonCustomerControl_Click(object sender, EventArgs e) {
            EditCustomerForm form;
            if (listBoxCustomers.SelectedItem == null) {
                form = new EditCustomerForm();
            } else {
                form = new EditCustomerForm((Customer)listBoxCustomers.SelectedItem);
            }
            form.ShowDialog();
        }

        private void buttonShowBooking_Click(object sender, EventArgs e) {
            if (listBoxCustomers.SelectedValue != null) {
                CustomerBookingsForm form = new CustomerBookingsForm(((Customer)listBoxCustomers.SelectedValue).CustomerID);
                form.ShowDialog();

            }
        }
    }
}
