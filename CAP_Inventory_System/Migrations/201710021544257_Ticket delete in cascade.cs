namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ticketdeleteincascade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MOTagHeader", "TicketKey", "dbo.Ticket");
            AddForeignKey("dbo.MOTagHeader", "TicketKey", "dbo.Ticket", "TicketKey", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MOTagHeader", "TicketKey", "dbo.Ticket");
            AddForeignKey("dbo.MOTagHeader", "TicketKey", "dbo.Ticket", "TicketKey");
        }
    }
}
