using Reusable;

namespace CAP_Inventory_System
{
    public partial class InventoryEvent: BaseEntity
    {
        public override int id
        {
            get
            {
                return InventoryEventKey;
            }
        }
    }
}
