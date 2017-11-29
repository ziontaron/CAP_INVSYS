namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FSItemMastersupport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FS_ItemMaster",
                c => new
                    {
                        FS_ItemMaster_Key = c.Int(nullable: false, identity: true),
                        ItemNumber = c.String(maxLength: 50),
                        ItemDescription = c.String(maxLength: 100),
                        UM = c.String(maxLength: 10),
                        MakeBuyCode = c.String(maxLength: 10),
                        ItemReference1 = c.String(maxLength: 10),
                        CostType = c.String(maxLength: 10),
                        TotalRolledCost = c.Single(nullable: false),
                        ItemNumber_FSKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FS_ItemMaster_Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FS_ItemMaster");
        }
    }
}
