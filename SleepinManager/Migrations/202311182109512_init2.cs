namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "InvoiceID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "InvoiceID", c => c.Int(nullable: false));
        }
    }
}
