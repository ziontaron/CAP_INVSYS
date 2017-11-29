namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Motagcountcompdesc50to150 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MOTagCount", "Component_Desc", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MOTagCount", "Component_Desc", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
