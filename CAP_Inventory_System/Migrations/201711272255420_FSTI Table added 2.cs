namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FSTITableadded2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TicketCount", "FSTI_Transaction_key", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TicketCount", "FSTI_Transaction_key", c => c.Int(nullable: false));
        }
    }
}
