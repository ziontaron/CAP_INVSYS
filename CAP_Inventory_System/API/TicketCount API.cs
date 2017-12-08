using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP_Inventory_System.Logic;
using System.Data;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Ticket Count 
        public TicketCount Tag2TicketCount(TicketTag T)
        {
            TicketCount _ticket = new TicketCount();
            _ticket = Tag2Entity(T);
            _ticket = (TicketCount)_ticketCountLogic.ReadbyId(_ticket).Result;
            return _ticket;
        }
        #endregion
    }
}
