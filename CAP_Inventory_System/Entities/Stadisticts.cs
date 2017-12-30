using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    public class Stadisticts
    {
        public int TicketCounts { get; set; }
        public int MOTags { get; set; }
        public int MOTagsCounted { get; set; }
        public int TicketBlank { get; set; }
        public int TicketVerified { get; set; }
        public int TicketVoid { get; set; }
        public int TicketCounted { get; set; }
        public int TicketCountedPorcentage { get; set; }
        public int TotalTickets { get { return (TicketCounts + MOTags); } }
        public int TotalTicketsCounted { get { return (TicketCounted + MOTagsCounted); } }
    }
}
