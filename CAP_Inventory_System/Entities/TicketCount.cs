using Reusable;

namespace CAP_Inventory_System
{
    public partial class TicketCount: BaseEntity
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
