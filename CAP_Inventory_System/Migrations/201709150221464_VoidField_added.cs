namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VoidField_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketCount", "VoidTag", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketCount", "VoidTag");
        }
    }
}
