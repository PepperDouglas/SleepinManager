namespace SleepinManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time_of_creation_invoice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "CreatedDate");
        }
    }
}
