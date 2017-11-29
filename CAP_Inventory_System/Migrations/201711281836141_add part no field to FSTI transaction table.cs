namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpartnofieldtoFSTItransactiontable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FSTI_Transactions", "FS_PartNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FSTI_Transactions", "FS_PartNo");
        }
    }
}
