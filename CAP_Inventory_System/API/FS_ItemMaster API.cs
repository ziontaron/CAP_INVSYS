﻿using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {   
        public void AddItemtoIM(DataRow Item)
        {
            FS_ItemMaster FS_Item = new FS_ItemMaster(Item);
            _FS_ItemMasterLogic.Create(FS_Item);
        }
        public FS_Item LoadItemNo(string ItemNo)
        {
            FS_ItemMaster FS_Item = new FS_ItemMaster { ItemNumber = ItemNo };
            FS_Item= (FS_ItemMaster)_FS_ItemMasterLogic.ReadbyName(FS_Item).Result;
            FS_Item t = new FS_Item(FS_Item);
            return t;
        }
        public List<FS_Item> LoadItemMaster()
        {
            List<FS_Item> L = new List<FS_Item>();
            List<FS_ItemMaster> IM = new List<FS_ItemMaster>();
            IM = _FS_ItemMasterLogic.ReadAll();
            foreach (FS_ItemMaster i in IM)
            {
                L.Add(new FS_Item(i));
            }

            return L;

        }
    }
}
