namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesomethings : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bookings", "InvoiceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "InvoiceID", c => c.Int());
        }
    }
}
