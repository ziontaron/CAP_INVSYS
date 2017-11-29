namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FSTITransactionkeyaddedtoTicketcounttable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCount", "FSTI_Transaction_key", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketCount", "FSTI_Transaction_key");
        }
    }
}
