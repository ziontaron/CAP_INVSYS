namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationMassterTableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FS_LocationMaster",
                c => new
                    {
                        FS_LocationMaster_Key = c.Int(nullable: false, identity: true),
                        STK = c.String(),
                        BIN = c.String(),
                    })
                .PrimaryKey(t => t.FS_LocationMaster_Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FS_LocationMaster");
        }
    }
}
