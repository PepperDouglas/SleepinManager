namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Customer_CustomerID = c.Int(nullable: false),
                        Room_RoomID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.BookingID)
                .ForeignKey("dbo.Rooms", t => t.Room_RoomID, cascadeDelete: true)
                .Index(t => t.BookingID)
                .Index(t => t.Customer_CustomerID)
                .Index(t => t.Room_RoomID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        SurName = c.String(nullable: false, maxLength: 30),
                        Email = c.String(maxLength: 60),
                        Telephone = c.String(maxLength: 18),
                        Nationality = c.String(nullable: false, maxLength: 20),
                        National_Identifier = c.String(nullable: false, maxLength: 18),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        Cost = c.Int(nullable: false),
                        HasBeenPaid = c.Boolean(nullable: false),
                        HasBeenAnnulled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomSize = c.Int(nullable: false),
                        ExtraBedCount = c.Int(nullable: false),
                        RoomType_RoomTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.RoomTypes", t => t.RoomType_RoomTypeID, cascadeDelete: true)
                .Index(t => t.RoomType_RoomTypeID);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        RoomTypeID = c.Int(nullable: false, identity: true),
                        RoomTypeName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.RoomTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Room_RoomID", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "RoomType_RoomTypeID", "dbo.RoomTypes");
            DropForeignKey("dbo.Bookings", "BookingID", "dbo.Invoices");
            DropForeignKey("dbo.Bookings", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.Rooms", new[] { "RoomType_RoomTypeID" });
            DropIndex("dbo.Bookings", new[] { "Room_RoomID" });
            DropIndex("dbo.Bookings", new[] { "Customer_CustomerID" });
            DropIndex("dbo.Bookings", new[] { "BookingID" });
            DropTable("dbo.RoomTypes");
            DropTable("dbo.Rooms");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
