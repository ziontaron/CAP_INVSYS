using Reusable;

namespace CAP_Inventory_System
{
    public partial class Ticket : BaseEntity
    {
        public override int id
        {
            get
            {
                return TicketKey;
            }
        }
    }
}
