using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepinManager.Repository
{
    public static class CustomerRepo
    {
        private static ManagerContext _db = new ManagerContext();

        public static List<Customer> GetCustomersByFilter(string condition) {
            bool isNumber = int.TryParse(condition, out _);           
            if (isNumber) {
                return _db.Customers.Where(a => a.National_Identifier.Contains(condition)).ToList();

            }
            return _db.Customers.Where(c => condition.Contains(c.FirstName) || condition.Contains(c.SurName)).ToList();
        }

        public static Customer GetCustomer(int id) {
            return _db.Customers.Find(id);
        }

        public static void AddCustomer(Customer customer) {
            try {
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }
            catch {
                MessageBox.Show("Fill out all the required fields");
            }
        }

        public static void DeleteCustomer(int customerID) {
            try {
                Customer customer = GetCustomer(customerID);
                _db.Customers.Remove(customer);
                _db.SaveChanges();
            }
            catch (Exception ex) {
                MessageBox.Show("Please remove all bookings from customer before removing customer");
            }
        }

        public static void UpdateCustomer(Customer updatedCustomer) {
            try {
                Customer oldCustomer = GetCustomer(updatedCustomer.CustomerID);
                _db.Entry(oldCustomer).CurrentValues.SetValues(updatedCustomer);
                _db.SaveChanges();               
            }
            catch {
                MessageBox.Show("Fill out all the required fields");
            }
        }
    }
}
