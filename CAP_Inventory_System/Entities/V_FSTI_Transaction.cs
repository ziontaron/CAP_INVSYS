using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System
{
    public partial class V_FSTI_Transaction : BaseEntity
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
