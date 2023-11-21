namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moved_extra_beds2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rooms", "ExtraBedCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "ExtraBedCount", c => c.Int(nullable: false));
        }
    }
}
