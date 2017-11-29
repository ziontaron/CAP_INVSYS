using System;
using Reusable;

namespace CAP_Inventory_System
{
    public partial class FSTI_Transactions : BaseEntity
    {
        public override int id
        {
            get
            {
                return FSTI_Transaction_key;
            }
        }
    }
}
