namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlagsforTicketCountsandMOTags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InventoryEvent", "TicketCountTags", c => c.Boolean(nullable: false));
            AddColumn("dbo.InventoryEvent", "MOTags", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InventoryEvent", "MOTags");
            DropColumn("dbo.InventoryEvent", "TicketCountTags");
        }
    }
}
