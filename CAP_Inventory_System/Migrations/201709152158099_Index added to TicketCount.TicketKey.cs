namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndexaddedtoTicketCountTicketKey : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TicketCount", new[] { "TicketKey" });
            CreateIndex("dbo.TicketCount", "TicketKey");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TicketCount", new[] { "TicketKey" });
            CreateIndex("dbo.TicketCount", "TicketKey");
        }
    }
}
