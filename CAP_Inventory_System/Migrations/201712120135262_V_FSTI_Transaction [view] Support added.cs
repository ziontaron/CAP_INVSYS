namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V_FSTI_TransactionviewSupportadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.V_FSTI_Transaction",
                c => new
                    {
                        FSTI_Transaction_key = c.Int(nullable: false, identity: true),
                        InventoryEventName = c.String(),
                        TicketCounter = c.Int(nullable: false),
                        TransactionType = c.String(),
                        TransactionStringFields = c.String(),
                        TransactionProcessedYN = c.Boolean(nullable: false),
                        FSResponse = c.String(),
                        FSError = c.Boolean(),
                        DateStampIn = c.DateTime(nullable: false),
                        DateStampOut = c.DateTime(),
                        FS_PartNo = c.String(),
                        TagCountKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FSTI_Transaction_key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.V_FSTI_Transaction");
        }
    }
}
