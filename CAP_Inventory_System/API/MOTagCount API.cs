using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region MO Tag Line
        public void CreateMOTagLine(MOTagLine MTL)
        {
            MOTagCount _moTagLine = new MOTagCount();
            _moTagLine = MOTagLine2Entity(MTL);
            _moTagCountLogic.Create(_moTagLine);
        }
        public void UpdateMOMOTagLine(MOTagLine MTL)
        {
            MOTagCount _moTagCount = new MOTagCount();
            _moTagCount = MOTagLine2Entity(MTL);
            _moTagCountLogic.Update(_moTagCount);
        }

        public DataTable MOTagLines2Table(int MOTagHeaderID)
        {
            DataTable _MTDT = new DataTable();

            //-----------HEADER--------------------//
            _MTDT.Columns.Add("SeqNum", typeof(int));
            _MTDT.Columns.Add("Component_No", typeof(string));
            _MTDT.Columns.Add("Component_Desc", typeof(string));
            _MTDT.Columns.Add("UM", typeof(string));
            _MTDT.Columns.Add("Qty_Per", typeof(int));
            _MTDT.Columns.Add("Issued_Qty", typeof(int));
            _MTDT.Columns.Add("LooseCountQty", typeof(string));
            _MTDT.Columns.Add("LooseReCountQty", typeof(int));
            
            //-----------Keys----------------------//
            _MTDT.Columns.Add("MOTagID", typeof(int));
            _MTDT.Columns.Add("MOTagLineID", typeof(int));

            List<MOTagCount> _MOList = _moTagCountLogic.ReadAll(MOTagHeaderID);
            MOTagLine _MT = new MOTagLine();

            for (int i = 0; i < _MOList.Count; i++)
            {                
                _MT = Entity2MOTagLine(_MOList[i]);
                _MTDT.Rows.Add(_MT.SeqNum
                    , _MT.Component_No
                    , _MT.Component_Desc
                    , _MT.UM
                    , _MT.Qty_Per
                    , _MT.Issued_Qty
                    , _MT.LooseCountQty
                    , _MT.LooseReCountQty
                    , _MT.MOTagID
                    , _MT.MOTagLineID);
            }
            return _MTDT;
        }
        #endregion
    }
}
