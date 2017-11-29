using Reusable;

namespace CAP_Inventory_System
{
    public partial class cat_TicketType : BaseEntity
    {
        public cat_TicketType(string _type)
        {
            TicketType = _type;
        }
        public override int id
        {
            get
            {
                return TicketTypeKey;
            }
        }
    }
}
