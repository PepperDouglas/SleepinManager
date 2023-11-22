using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepinManager.Repository
{
    public static class InvoiceRepo
    {
        private static ManagerContext _db = new ManagerContext();

        public static Invoice GetInvoiceByID(int invoiceID) {
            return _db.Invoices.Find(invoiceID);
        }

        public static void UpdateInvoice(Invoice invoice) {
            Invoice oldInvoice = GetInvoiceByID(invoice.InvoiceID);
            _db.Entry(oldInvoice).CurrentValues.SetValues(invoice);
            _db.SaveChanges();
        }

        public static void AnnullExpired() {
            List<Invoice> invoices = new List<Invoice>();
            
            invoices = _db.Invoices.Where(i => i.HasBeenPaid == false && DbFunctions.DiffDays(i.CreatedDate, DateTime.Now) > 10).ToList();
            foreach (Invoice invoice in invoices) {
                invoice.HasBeenAnnulled = true;
                //might not work
                _db.Entry(invoice).CurrentValues.SetValues(invoice);
                _db.SaveChanges();
            }
        }

        public static List<int> GetAnnulledInvoiceIDs() {
            List<Invoice> InvoiceIds = _db.Invoices.Where(i => i.HasBeenAnnulled == true).ToList();
            List<int> ids = new List<int>();
            foreach (Invoice invoice in InvoiceIds) {
                ids.Add(invoice.InvoiceID);
            }
            return ids;
        }
    }
}
