namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moved_extra_beds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "ExtraBedCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "ExtraBedCount");
        }
    }
}
