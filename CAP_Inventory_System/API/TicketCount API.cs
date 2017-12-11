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
        public void CreateFSTITransaction(DataRow R)
        {
            TicketCount t = new CAP_Inventory_System.TicketCount();
            t.TagCountKey = Convert.ToInt32( R["TagCountKey"].ToString());
            t.TicketKey=Convert.ToInt32(R["TicketKey"].ToString());
            t = (TicketCount)_ticketCountLogic.ReadbyId(t).Result;
            Attach_FSTI_Transacion(t, R["DocNum"].ToString(), R["InvAccount"].ToString(), R["ReasonCode"].ToString(),R["Remark"].ToString());
        }
        #endregion
    }
}
