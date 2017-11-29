using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Reusable;

namespace CAP_Inventory_System
{
    public partial class FS_ItemMaster : BaseEntity
    {
        public FS_ItemMaster() { }
        public FS_ItemMaster(DataRow Item)
        {
            ItemNumber = Item["ItemNumber"].ToString();
            ItemDescription = Item["ItemDescription"].ToString();
            ItemUM = Item["ItemUM"].ToString();
            ItemRevision = Item["ItemRevision"].ToString();
            MakeBuyCode = Item["MakeBuyCode"].ToString();
            ItemReference1 = Item["ItemReference1"].ToString();
            CostType = Item["CostType"].ToString();
            TotalRolledCost = float.Parse(Item["TotalRolledCost"].ToString());
            ItemNumber_FSKey = Convert.ToInt32(Item["ItemKey"].ToString());
        }

        public override int id
        {
            get
            {
                return FS_ItemMaster_Key;
            }
        }

    }
}
