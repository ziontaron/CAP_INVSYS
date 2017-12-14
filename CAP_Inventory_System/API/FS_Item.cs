using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    public class FS_Item
    {
        public FS_Item(FS_ItemMaster e)
        {
            if (e != null)
            {
                ItemNumber_FSKey = e.ItemNumber_FSKey;
                ItemNo = e.ItemNumber;
                ItemDesc = e.ItemDescription;
                ItemUM = e.ItemUM;
                ItemRevision = e.ItemRevision;
                ItemReference1 = e.ItemReference1;
                Cost = e.TotalRolledCost;
            }
        }

        public int ItemNumber_FSKey { get; set; }
        public string ItemNo { get; set; }
        public string ItemDesc { get; set; }
        public string ItemUM { get; set; }
        public string ItemRevision { get; set; }
        public string ItemReference1 { get; set; }
        public float Cost { get; set; }
    }
}
