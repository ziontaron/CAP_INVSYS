using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public class TicketTag
    {
        public TicketTag() { }
        public int Counter { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string ItemReference1 { get; set; }
        public string ItemUM { get; set; }
        public string Stockroom { get; set; }
        public string Bin { get; set; }
        public string InventoryCategory { get; set; }
        public float InventoryQuantity { get; set; }
        public string LotNumber { get; set; }

        public float CountQTY { get; set; }
        public float ReCountQTY { get; set; }
        public bool Verified { get; set; }
        public bool BlankTag { get; set; }
        public bool VoidTag { get; set; }
        public string CounterInitials { get; set; }
        public DateTime? CountedDate { get; set; }

        //public float Balance { get; set; }
        public int ItemNumber_FSKey { get; set; }
        public int TicketID { get; set; }
        public int TicketCountID { get; set; }
        public int EventID { get; set; }
    }
    public static class TicketTagLogic
    {
        public static TicketTag DataRow2Tag(DataRow r)
        {
            TicketTag _tag = new TicketTag();
            _tag.Counter = Convert.ToInt32(r["Counter"].ToString());
            _tag.ItemNumber = r["ItemNumber"].ToString();
            _tag.ItemDescription = r["ItemDescription"].ToString();
            _tag.ItemReference1 = r["ItemReference1"].ToString();
            _tag.ItemUM = r["ItemUM"].ToString();
            _tag.Stockroom = r["Stockroom"].ToString();
            _tag.Bin = r["Bin"].ToString();
            _tag.InventoryCategory = r["InventoryCategory"].ToString();
            _tag.InventoryQuantity = float.Parse(r["InventoryQuantity"].ToString());
            _tag.LotNumber = r["LotNumber"].ToString();
            _tag.ItemNumber_FSKey= Convert.ToInt32(r["ItemKey"].ToString());

            return _tag;
        }
        public static TicketCount Tag2TicketCount(TicketTag T)
        {
            TicketCount _ticket = new TicketCount();
            _ticket.TagCountKey = T.TicketID;
            TicketCountLogic _ticketLogic = new Logic.TicketCountLogic();
            _ticket = (TicketCount) _ticketLogic.ReadbyId(_ticket).Result;
            return _ticket;
        }
    }
}
