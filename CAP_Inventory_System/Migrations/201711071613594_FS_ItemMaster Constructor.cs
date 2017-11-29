namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FS_ItemMasterConstructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FS_ItemMaster", "ItemUM", c => c.String(maxLength: 10));
            AddColumn("dbo.FS_ItemMaster", "ItemRevision", c => c.String(maxLength: 10));
            DropColumn("dbo.FS_ItemMaster", "UM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FS_ItemMaster", "UM", c => c.String(maxLength: 10));
            DropColumn("dbo.FS_ItemMaster", "ItemRevision");
            DropColumn("dbo.FS_ItemMaster", "ItemUM");
        }
    }
}
