using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public class MOTag
    {
        public MOTag() { }

        //-----------HEADER--------------------//
        public int Counter { get; set; }
        public string Planner { get; set; }
        public string MO { get; set; }
        public string MO_Ln { get; set; }
        public string MO_Status { get; set; }
        public int Order_Qty { get; set; }
        public int Recv_Qty { get; set; }
        public string LineType { get; set; }
        public int FGinWip { get; set; }

        //-----------TITTLE--------------------//
        public string Parent_Item_NO { get; set; }
        public string Parent_Item_Desc { get; set; }
        public string Parent_ItemRef1 { get; set; }

        //-----------BODY--------------------//
        List<MOTagLine> ComponentLines { get; set; }

        //-----------FOOTER--------------------//  

        public string CounterInitials { get; set; }
        public DateTime? CountedDate { get; set; }

        //-----------Keys----------------------//

        public int MOTagID { get; set; }
        public int TicketID { get; set; }

    }
    public static class MOTagLogic
    {
        public static MOTag DataRow2MOTag(DataRow r)
        {
            MOTag _MOtag = new MOTag();
            //_MOtag.Counter = Convert.ToInt32(r["Counter"].ToString());
            _MOtag.Planner= r["Planner"].ToString();
            _MOtag.MO = r["MONumber"].ToString();
            _MOtag.MO_Ln = r["MOLineNumberString"].ToString();
            _MOtag.MO_Status = r["MOLineStatus"].ToString();
            _MOtag.LineType= r["MOLineType"].ToString();
            _MOtag.Order_Qty = Convert.ToInt32(r["ItemOrderedQuantity"].ToString());
            _MOtag.Recv_Qty = Convert.ToInt32(r["ReceiptQuantity"].ToString());

            _MOtag.Parent_Item_NO = r["ItemNumber"].ToString();
            _MOtag.Parent_Item_Desc = r["ItemDescription"].ToString();
            _MOtag.Parent_ItemRef1 = r["ItemReference1"].ToString();

            return _MOtag;
        }
    }
    
}
