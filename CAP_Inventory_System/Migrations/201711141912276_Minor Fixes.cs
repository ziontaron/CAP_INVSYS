namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorFixes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FS_ItemMaster", "ItemNumber_FSKey", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.FS_ItemMaster", new[] { "ItemNumber_FSKey" });
        }
    }
}
