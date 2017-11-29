namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fginwipfieldaddtoMOTagheader : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MOTagHeader", "FG_Qty_in_WIP", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MOTagHeader", "FG_Qty_in_WIP");
        }
    }
}
