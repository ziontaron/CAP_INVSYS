namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolltoRoleCorrection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "UserRollKey", "dbo.cat_UserRoll");
            DropIndex("dbo.User", new[] { "UserRollKey" });
            CreateTable(
                "dbo.cat_UserRole",
                c => new
                    {
                        UserRoleKey = c.Int(nullable: false, identity: true),
                        UserRole = c.String(nullable: false, maxLength: 10),
                        UserRoleDesc = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UserRoleKey);
            
            AddColumn("dbo.User", "UserRoleKey", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "UserRoleKey");
            AddForeignKey("dbo.User", "UserRoleKey", "dbo.cat_UserRole", "UserRoleKey", cascadeDelete: true);
            DropColumn("dbo.User", "UserRollKey");
            DropTable("dbo.cat_UserRoll");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.User", "UserRollKey", c => c.Int(nullable: false));
            DropForeignKey("dbo.User", "UserRoleKey", "dbo.cat_UserRole");
            DropIndex("dbo.User", new[] { "UserRoleKey" });
            DropColumn("dbo.User", "UserRoleKey");
            DropTable("dbo.cat_UserRole");
            CreateIndex("dbo.User", "UserRollKey");
            AddForeignKey("dbo.User", "UserRollKey", "dbo.cat_UserRoll", "UserRollKey", cascadeDelete: true);
        }
    }
}
