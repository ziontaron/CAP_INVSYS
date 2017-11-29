using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public class MOTagLine
    {
        public MOTagLine() { }

        public int SeqNum { get; set; }
        public string Component_No { get; set; }
        public string Component_Desc { get; set; }
        public string UM { get; set; }

        public float Qty_Per { get; set; }
        public float Issued_Qty { get; set; }
        public float LooseCountQty { get; set; }
        public float LooseReCountQty { get; set; }

        public int MOTagID { get; set; }
        public int MOTagLineID { get; set; }

    }
    public static class MOTagLineLogic
    {
        public static MOTagLine DataRow2MOTagLine(DataRow r)
        {
            MOTagLine _MOTLine = new MOTagLine();

            _MOTLine.SeqNum = Convert.ToInt32(r["OperationSequenceNumberString"].ToString());
            _MOTLine.UM = r["ComponentUM"].ToString();
            _MOTLine.Component_No = r["Component"].ToString();
            _MOTLine.Component_Desc = r["ComponentDescription"].ToString();

            _MOTLine.Qty_Per = float.Parse(r["RequiredQuantity"].ToString());
            _MOTLine.Issued_Qty = float.Parse(r["IssuedQuantity"].ToString());
            _MOTLine.LooseCountQty = float.Parse(r["LooseCountQty"].ToString());
            _MOTLine.LooseReCountQty = float.Parse(r["LooseReCountQty"].ToString());

            return _MOTLine;
        }
        public static MOTagLine DataRow2MOTagLine_FromDGV(DataRow r)
        {
            MOTagLine _MOTLine = new MOTagLine();

            _MOTLine.SeqNum = Convert.ToInt32(r["SeqNum"].ToString());
            _MOTLine.UM = r["UM"].ToString();
            _MOTLine.Component_No = r["Component_No"].ToString();
            _MOTLine.Component_Desc = r["Component_Desc"].ToString();

            _MOTLine.Qty_Per = Convert.ToInt32(r["Qty_Per"].ToString());
            _MOTLine.Issued_Qty = Convert.ToInt32(r["Issued_Qty"].ToString());
            _MOTLine.LooseCountQty = Convert.ToInt32(r["LooseCountQty"].ToString());
            _MOTLine.LooseReCountQty = Convert.ToInt32(r["LooseReCountQty"].ToString());

            _MOTLine.MOTagID = Convert.ToInt32(r["MOTagID"].ToString());
            _MOTLine.MOTagLineID = Convert.ToInt32(r["MOTagLineID"].ToString());
            
            return _MOTLine;
        }
    }
}
