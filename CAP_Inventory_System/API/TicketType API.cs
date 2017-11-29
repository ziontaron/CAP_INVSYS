using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Ticket Type
        public void CreateTicketType(string Ticket_Type, string Type_Description)
        {
            cat_TicketType entity = new cat_TicketType
            {
                TicketType = Ticket_Type,
                TicketTypeDescirption = Type_Description
            };
            _Response = _cat_TicketTypeLogic.Create(entity);
        }
        public void ReadTicketTypebyName(string Type_name)
        {
            cat_TicketType entity = new cat_TicketType
            {
                TicketTypeKey = 0,
                TicketType = Type_name,
                TicketTypeDescirption = ""
            };
            _Response = _cat_TicketTypeLogic.ReadbyName(entity);
        }
        public void ReadTicketbyId(int Type_Id)
        {
            cat_TicketType entity = new cat_TicketType
            {
                TicketTypeKey = Type_Id,
                TicketType = "",
                TicketTypeDescirption = ""
            };
            _Response = _cat_TicketTypeLogic.ReadbyId(entity);

        }
        public List<string> ReadAllTicketTypes()
        {
            List<string> L = new List<string>();
            foreach (cat_TicketType e in _cat_TicketTypeLogic.ReadAll())
            {
                L.Add(e.TicketType);
            }
            return L;
        }
        public void UpdateTicketType(string Ticket_Type, string Type_Desc)
        {
            cat_TicketType entity = new cat_TicketType
            {
                TicketType = Ticket_Type,
                TicketTypeDescirption = Type_Desc
            };
            _Response = _cat_TicketTypeLogic.Update(entity);
        }
        public void DeleteTicketType(int TicketType_Id)
        {
            cat_TicketType entity = new cat_TicketType { TicketTypeKey = TicketType_Id };
            CommonResponse result = _cat_TicketTypeLogic.Delete(entity);
        }
        #endregion
    }
}
