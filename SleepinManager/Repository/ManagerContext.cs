using SleepinManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Repository
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() : base("SleepinManagerConnection") { 
            
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Booking>()
                .HasOptional(b => b.Invoice)
                .WithRequired(i => i.Booking);

            modelBuilder.Entity<Invoice>()
                .HasKey(i => i.InvoiceID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
