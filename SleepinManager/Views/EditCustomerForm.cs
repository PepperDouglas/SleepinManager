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
    public partial class EditCustomerForm : Form
    {
        public Customer Customer { get; set; }
        public bool NoCustomer { get; set; }
        public EditCustomerForm() {
            InitializeComponent();
            NoCustomer = true;
        }

        public EditCustomerForm(Customer customer) {
            InitializeComponent();
            Customer = customer;
            NoCustomer = false;
            UpdateDetails(Customer);
        }

        private void UpdateDetails(Customer customer) {
            textBoxFirstName.Text = customer.FirstName;
            textBoxSurName.Text = customer.SurName;
            textBoxEmail.Text = customer.Email;
            textBoxTelephone.Text = customer.Telephone;
            textBoxNationality.Text = customer.Nationality;
            textBoxNationalID.Text = customer.National_Identifier;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e) {
            Customer customer = new Customer()
            {
                FirstName = textBoxFirstName.Text,
                SurName = textBoxSurName.Text,
                Email = textBoxEmail.Text,
                Telephone = textBoxTelephone.Text,
                Nationality = textBoxNationality.Text,
                National_Identifier = textBoxNationalID.Text
            };
            CustomerRepo.AddCustomer(customer);
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e) {      
            if (!NoCustomer) {
                CustomerRepo.UpdateCustomer(new Customer()
                {
                    CustomerID = Customer.CustomerID,
                    FirstName = textBoxFirstName.Text,
                    SurName = textBoxSurName.Text,
                    Email = textBoxEmail.Text,
                    Telephone = textBoxTelephone.Text,
                    Nationality = textBoxNationality.Text,
                    National_Identifier = textBoxNationalID.Text
                });
            } else {
                MessageBox.Show("Please select customer in the previous window");
            }
        }
        private void buttonRemoveCustomer_Click(object sender, EventArgs e) {
            if (!NoCustomer) {
                CustomerRepo.DeleteCustomer(Customer.CustomerID);
            } else {
                MessageBox.Show("Please select customer in the previous window");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
