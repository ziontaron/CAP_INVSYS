namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MOtagFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MOTagHeader", "Recv_Qty", c => c.Int());
            AddColumn("dbo.MOTagHeader", "Parent_Item_NO", c => c.String(maxLength: 50));
            AddColumn("dbo.MOTagHeader", "Parent_Item_Desc", c => c.String(maxLength: 50));
            AddColumn("dbo.MOTagHeader", "Parent_ItemRef1", c => c.String(maxLength: 5));
            AddColumn("dbo.MOTagHeader", "CounterInitials", c => c.String(maxLength: 10));
            AddColumn("dbo.MOTagHeader", "CountedDate", c => c.DateTime());
            AddColumn("dbo.MOTagCount", "Component_No", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.MOTagCount", "Component_Desc", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.MOTagCount", "Qty_Per", c => c.Single(nullable: false));
            AddColumn("dbo.MOTagCount", "Issued_Qty", c => c.Single(nullable: false));
            DropColumn("dbo.MOTagHeader", "QtyRecv");
            DropColumn("dbo.MOTagHeader", "QtyWip");
            DropColumn("dbo.MOTagCount", "Component");
            DropColumn("dbo.MOTagCount", "CompDesc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MOTagCount", "CompDesc", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.MOTagCount", "Component", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.MOTagHeader", "QtyWip", c => c.Int());
            AddColumn("dbo.MOTagHeader", "QtyRecv", c => c.Int());
            DropColumn("dbo.MOTagCount", "Issued_Qty");
            DropColumn("dbo.MOTagCount", "Qty_Per");
            DropColumn("dbo.MOTagCount", "Component_Desc");
            DropColumn("dbo.MOTagCount", "Component_No");
            DropColumn("dbo.MOTagHeader", "CountedDate");
            DropColumn("dbo.MOTagHeader", "CounterInitials");
            DropColumn("dbo.MOTagHeader", "Parent_ItemRef1");
            DropColumn("dbo.MOTagHeader", "Parent_Item_Desc");
            DropColumn("dbo.MOTagHeader", "Parent_Item_NO");
            DropColumn("dbo.MOTagHeader", "Recv_Qty");
        }
    }
}
