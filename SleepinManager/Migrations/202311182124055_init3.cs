namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Bookings", name: "Customer_CustomerID", newName: "CustomerID");
            RenameColumn(table: "dbo.Bookings", name: "Room_RoomID", newName: "RoomID");
            RenameIndex(table: "dbo.Bookings", name: "IX_Room_RoomID", newName: "IX_RoomID");
            RenameIndex(table: "dbo.Bookings", name: "IX_Customer_CustomerID", newName: "IX_CustomerID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Bookings", name: "IX_CustomerID", newName: "IX_Customer_CustomerID");
            RenameIndex(table: "dbo.Bookings", name: "IX_RoomID", newName: "IX_Room_RoomID");
            RenameColumn(table: "dbo.Bookings", name: "RoomID", newName: "Room_RoomID");
            RenameColumn(table: "dbo.Bookings", name: "CustomerID", newName: "Customer_CustomerID");
        }
    }
}
