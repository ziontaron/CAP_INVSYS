namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastDB_ver : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cat_TicketType",
                c => new
                    {
                        TicketTypeKey = c.Int(nullable: false, identity: true),
                        TicketType = c.String(nullable: false, maxLength: 50),
                        TicketTypeDescirption = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TicketTypeKey);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        TicketKey = c.Int(nullable: false, identity: true),
                        TicketCounter = c.Int(nullable: false),
                        cat_TicketTypeKey = c.Int(nullable: false),
                        InventoryEventKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketKey)
                .ForeignKey("dbo.InventoryEvent", t => t.InventoryEventKey, cascadeDelete: true)
                .ForeignKey("dbo.cat_TicketType", t => t.cat_TicketTypeKey, cascadeDelete: true)
                .Index(t => t.cat_TicketTypeKey)
                .Index(t => t.InventoryEventKey);
            
            CreateTable(
                "dbo.InventoryEvent",
                c => new
                    {
                        InventoryEventKey = c.Int(nullable: false, identity: true),
                        InventoryEventName = c.String(nullable: false, maxLength: 50),
                        InventoryEventDescription = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false, storeType: "date"),
                        TerminationDate = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InventoryEventKey);
            
            CreateTable(
                "dbo.MOTagHeader",
                c => new
                    {
                        MOTagHeaderKey = c.Int(nullable: false, identity: true),
                        TicketKey = c.Int(nullable: false),
                        Planner = c.String(maxLength: 50),
                        MO = c.String(maxLength: 50),
                        MO_Ln = c.String(maxLength: 10),
                        MO_Status = c.String(maxLength: 3),
                        Order_Qty = c.Int(),
                        QtyRecv = c.Int(),
                        LineType = c.String(maxLength: 3),
                        QtyWip = c.Int(),
                    })
                .PrimaryKey(t => t.MOTagHeaderKey)
                .ForeignKey("dbo.Ticket", t => t.TicketKey)
                .Index(t => t.TicketKey);
            
            CreateTable(
                "dbo.MOTagCount",
                c => new
                    {
                        MOTagCountKey = c.Int(nullable: false, identity: true),
                        MOTagHeaderKey = c.Int(nullable: false),
                        SeqNum = c.Int(nullable: false),
                        Component = c.String(nullable: false, maxLength: 50),
                        CompDesc = c.String(nullable: false, maxLength: 50),
                        UM = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.MOTagCountKey)
                .ForeignKey("dbo.MOTagHeader", t => t.MOTagHeaderKey, cascadeDelete: true)
                .Index(t => t.MOTagHeaderKey);
            
            CreateTable(
                "dbo.TicketCount",
                c => new
                    {
                        TagCountKey = c.Int(nullable: false, identity: true),
                        CounterInitials = c.String(maxLength: 10),
                        CountedDate = c.DateTime(),
                        TicketKey = c.Int(nullable: false),
                        ItemNumber = c.String(maxLength: 50),
                        ItemDescription = c.String(maxLength: 100),
                        ItemRef = c.String(maxLength: 10),
                        UM = c.String(maxLength: 10),
                        LotNumber = c.String(maxLength: 50),
                        CountQTY = c.Single(nullable: false),
                        ReCountQty = c.Single(nullable: false),
                        InventoryQty = c.Single(nullable: false),
                        SKT = c.String(maxLength: 15),
                        BIN = c.String(maxLength: 15),
                        IC = c.String(maxLength: 3),
                        Verified = c.Boolean(nullable: false),
                        CountStatus = c.String(maxLength: 10),
                        BlankTag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TagCountKey)
                .ForeignKey("dbo.Ticket", t => t.TicketKey, cascadeDelete: true)
                .Index(t => t.TicketKey);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ticket", "cat_TicketTypeKey", "dbo.cat_TicketType");
            DropForeignKey("dbo.TicketCount", "TicketKey", "dbo.Ticket");
            DropForeignKey("dbo.MOTagHeader", "TicketKey", "dbo.Ticket");
            DropForeignKey("dbo.MOTagCount", "MOTagHeaderKey", "dbo.MOTagHeader");
            DropForeignKey("dbo.Ticket", "InventoryEventKey", "dbo.InventoryEvent");
            DropIndex("dbo.TicketCount", new[] { "TicketKey" });
            DropIndex("dbo.MOTagCount", new[] { "MOTagHeaderKey" });
            DropIndex("dbo.MOTagHeader", new[] { "TicketKey" });
            DropIndex("dbo.Ticket", new[] { "InventoryEventKey" });
            DropIndex("dbo.Ticket", new[] { "cat_TicketTypeKey" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.TicketCount");
            DropTable("dbo.MOTagCount");
            DropTable("dbo.MOTagHeader");
            DropTable("dbo.InventoryEvent");
            DropTable("dbo.Ticket");
            DropTable("dbo.cat_TicketType");
        }
    }
}
