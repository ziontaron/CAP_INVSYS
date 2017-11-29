namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTablesadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cat_UserRoll",
                c => new
                    {
                        UserRollKey = c.Int(nullable: false, identity: true),
                        UserRoll = c.String(nullable: false, maxLength: 10),
                        UserRollDesc = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserRollKey);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserKey = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 50),
                        UserRollKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserKey)
                .ForeignKey("dbo.cat_UserRoll", t => t.UserRollKey, cascadeDelete: true)
                .Index(t => t.UserRollKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserRollKey", "dbo.cat_UserRoll");
            DropIndex("dbo.User", new[] { "UserRollKey" });
            DropTable("dbo.User");
            DropTable("dbo.cat_UserRoll");
        }
    }
}
