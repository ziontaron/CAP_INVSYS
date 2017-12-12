namespace CAP_Inventory_System.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Reusable;
    using CAP_Inventory_System;
    using Logic;

    internal sealed class Configuration : DbMigrationsConfiguration<CAPA_INVContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CAPA_INVContext context)
        {
            cat_TicketTypeLogic _cat_TicketTypeLogic = new cat_TicketTypeLogic();
            _cat_TicketTypeLogic.Create(new cat_TicketType { TicketType = "TicketCount", TicketTypeDescirption = "Ticket Tag Count" });
            _cat_TicketTypeLogic.Create(new cat_TicketType { TicketType = "MOTagHeader", TicketTypeDescirption = "MO Tag Header" });

            cat_UserRoleLogic _cat_UserRoleLogic = new cat_UserRoleLogic();
            _cat_UserRoleLogic.Create(new cat_UserRole { UserRole = "SysAdmin", UserRoleDesc = "System Administrator Full Access." });
            _cat_UserRoleLogic.Create(new cat_UserRole { UserRole = "EventAdmin", UserRoleDesc = "Event Administrator Full Event Admins Functions." });
            _cat_UserRoleLogic.Create(new cat_UserRole { UserRole = "StdUser", UserRoleDesc = "Standar User." });

            UserLogic _UserLogic = new UserLogic();
            string Admin = "Admin";
            cat_UserRole _userRole = (cat_UserRole)(_cat_UserRoleLogic.ReadbyName(new cat_UserRole { UserRole = "SysAdmin" }).Result);
            _UserLogic.Create(new User
            {
                UserName = Admin,
                Password = "capsonic",
                UserRoleKey = _userRole.UserRoleKey
            });

            #region V_FSTI_Transaction View Setup
            string V_FSTI_Transaction_DROP_V = @"DROP VIEW [dbo].[V_FSTI_Transaction]";
            string V_FSTI_Transaction_DROP_T = @"DROP TABLE [dbo].[V_FSTI_Transaction]";
            string V_FSTI_Transaction_CREATE = @"CREATE VIEW [dbo].[V_FSTI_Transaction] AS
                                       SELECT InventoryEvent.InventoryEventName, Ticket.TicketCounter, FSTI_Transactions.FSTI_Transaction_key, FSTI_Transactions.TransactionType, FSTI_Transactions.TransactionStringFields, 
                      FSTI_Transactions.TransactionProcessedYN, FSTI_Transactions.FSResponse, FSTI_Transactions.FSError, FSTI_Transactions.DateStampIn, FSTI_Transactions.DateStampOut, 
                      FSTI_Transactions.FS_PartNo, FSTI_Transactions.TagCountKey, InventoryEvent.InventoryEventKey
                      FROM Ticket INNER JOIN
                      TicketCount ON Ticket.TicketKey = TicketCount.TicketKey INNER JOIN
                      InventoryEvent ON Ticket.InventoryEventKey = InventoryEvent.InventoryEventKey INNER JOIN
                      FSTI_Transactions ON TicketCount.TagCountKey = FSTI_Transactions.TagCountKey";
            context.DB_MNG.Execute_Command(V_FSTI_Transaction_DROP_T);
            context.DB_MNG.Execute_Command(V_FSTI_Transaction_DROP_V);
            context.DB_MNG.Execute_Command(V_FSTI_Transaction_CREATE);
            #endregion

        }
    }
}
