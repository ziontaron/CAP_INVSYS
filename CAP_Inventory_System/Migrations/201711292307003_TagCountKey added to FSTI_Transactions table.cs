namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TagCountKeyaddedtoFSTI_Transactionstable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FSTI_Transactions", "TagCountKey", c => c.Int(nullable: false));
            //AddColumn("dbo.FSTI_Transactions", "FS_PartNo", c => c.String(nullable: false));
            DropColumn("dbo.TicketCount", "FSTI_Transaction_key");
            //DropColumn("dbo.FSTI_Transactions", "FS_PastNo");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.FSTI_Transactions", "FS_PastNo", c => c.String(nullable: false));
            AddColumn("dbo.TicketCount", "FSTI_Transaction_key", c => c.Int());
            //DropColumn("dbo.FSTI_Transactions", "FS_PartNo");
            DropColumn("dbo.FSTI_Transactions", "TagCountKey");
        }
    }
}
