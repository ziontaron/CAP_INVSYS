namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FSItemKeyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCount", "ItemNumber_FSKey", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketCount", "ItemNumber_FSKey");
        }
    }
}
