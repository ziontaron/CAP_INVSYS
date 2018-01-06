namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountedByfieldadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCount", "CapturedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketCount", "CapturedBy");
        }
    }
}
