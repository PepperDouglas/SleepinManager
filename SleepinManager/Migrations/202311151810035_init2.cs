namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "BookingID", "dbo.Invoices");
            DropIndex("dbo.Bookings", new[] { "BookingID" });
            DropPrimaryKey("dbo.Bookings");
            AddColumn("dbo.Bookings", "Invoice_InvoiceID", c => c.Int(nullable: false));
            AlterColumn("dbo.Bookings", "BookingID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingID");
            CreateIndex("dbo.Bookings", "Invoice_InvoiceID");
            AddForeignKey("dbo.Bookings", "Invoice_InvoiceID", "dbo.Invoices", "InvoiceID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Invoice_InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Bookings", new[] { "Invoice_InvoiceID" });
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingID", c => c.Int(nullable: false));
            DropColumn("dbo.Bookings", "Invoice_InvoiceID");
            AddPrimaryKey("dbo.Bookings", "BookingID");
            CreateIndex("dbo.Bookings", "BookingID");
            AddForeignKey("dbo.Bookings", "BookingID", "dbo.Invoices", "InvoiceID");
        }
    }
}
