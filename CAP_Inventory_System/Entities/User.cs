using Reusable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    public partial class User : BaseEntity
    {
        public override int id
        {
            get
            {
                return UserKey;
            }
        }
    }
}
