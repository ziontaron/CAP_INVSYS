using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        public void AddLocationtoLM(DataRow Location)
        {
            FS_LocationMaster FS_Loc= new FS_LocationMaster(Location);
            _FS_LocationMasterLogic.Create(FS_Loc);
        }
        public List<FS_LocationMaster> LoadAllLocations()
        {
            List<FS_LocationMaster> L = new List<FS_LocationMaster>();
            L = _FS_LocationMasterLogic.ReadAll();

            return L;
        }
        public List<string> LoadAllSTK()
        {
            List<string> L = new List<string>();
            L = _FS_LocationMasterLogic.ReadAll_STK();
            return L;
        }
        public List<string> LoadAllBIN()
        {
            List<string> L = new List<string>();
            L = _FS_LocationMasterLogic.ReadAll_BIN();
            return L;
        }
    }
}
