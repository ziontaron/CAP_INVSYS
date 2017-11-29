namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FSTITableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FSTI_Transactions",
                c => new
                    {
                        FSTI_Transaction_key = c.Int(nullable: false, identity: true),
                        TransactionType = c.String(nullable: false, maxLength: 50),
                        TransactionStringFields = c.String(nullable: false),
                        TransactionProcessedYN = c.Boolean(nullable: false),
                        FSResponse = c.String(),
                        FSError = c.Boolean(),
                        DateStampIn = c.DateTime(nullable: false),
                        DateStampOut = c.DateTime(),
                    })
                .PrimaryKey(t => t.FSTI_Transaction_key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FSTI_Transactions");
        }
    }
}
