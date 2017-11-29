namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountStatusremovedandFSItemMasterSupportAdded : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TicketCount", "CountStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketCount", "CountStatus", c => c.String(maxLength: 10));
        }
    }
}
