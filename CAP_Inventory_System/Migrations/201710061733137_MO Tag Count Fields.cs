namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MOTagCountFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MOTagCount", "LooseCountQty", c => c.Single(nullable: false));
            AddColumn("dbo.MOTagCount", "LooseReCountQty", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MOTagCount", "LooseReCountQty");
            DropColumn("dbo.MOTagCount", "LooseCountQty");
        }
    }
}
