namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MOtagheaderParent_Item_Desclength50to100 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MOTagHeader", "Parent_Item_Desc", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MOTagHeader", "Parent_Item_Desc", c => c.String(maxLength: 50));
        }
    }
}
