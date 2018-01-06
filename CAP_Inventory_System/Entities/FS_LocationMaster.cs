using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Reusable;

namespace CAP_Inventory_System
{
    public partial class FS_LocationMaster :BaseEntity
    {
        public FS_LocationMaster()
        { }

        public FS_LocationMaster(DataRow r)
        {
            STK = r["Stockroom"].ToString();
            BIN = r["Bin"].ToString();
        }
        
        public override int id
        {
            get
            {
                return FS_LocationMaster_Key;
            }
        }
    }
}
