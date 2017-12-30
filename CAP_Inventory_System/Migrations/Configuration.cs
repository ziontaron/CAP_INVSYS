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
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_Drop_T);
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_Drop_V);
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_CREATE);
            #endregion

            #region V_FinanceRep View Setup
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_Drop_T);
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_Drop_V);
            context.DB_MNG.Execute_Command(DB_VIEWS.FSTI_Tran_CREATE);
            #endregion

            #region v_MOTags View Setup
            context.DB_MNG.Execute_Command(DB_VIEWS.MOTags_Drop_T);
            context.DB_MNG.Execute_Command(DB_VIEWS.MOTags_Drop_V);
            context.DB_MNG.Execute_Command(DB_VIEWS.MOTags_CREATE);
            #endregion

        }
    }
}
