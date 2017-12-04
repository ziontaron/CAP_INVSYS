namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SKTtoSTK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCount", "STK", c => c.String(maxLength: 15));
            DropColumn("dbo.TicketCount", "SKT");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketCount", "SKT", c => c.String(maxLength: 15));
            DropColumn("dbo.TicketCount", "STK");
        }
    }
}
