using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP_Inventory_System.Logic;
using System.Data;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Ticket Count 
        public TicketCount Tag2TicketCount(TicketTag T)
        {
            TicketCount _ticket = new TicketCount();
            _ticket = Tag2Entity(T);
            _ticket = (TicketCount)_ticketCountLogic.ReadbyId(_ticket).Result;
            return _ticket;
        }
        public void CreateFSTITransaction(DataRow R)
        {
            TicketCount t = new CAP_Inventory_System.TicketCount();
            t.TagCountKey = Convert.ToInt32( R["TagCountKey"].ToString());
            t.TicketKey=Convert.ToInt32(R["TicketKey"].ToString());
            t = (TicketCount)_ticketCountLogic.ReadbyId(t).Result;
            Attach_FSTI_Transacion(t, R["DocNum"].ToString(), R["InvAccount"].ToString(), R["ReasonCode"].ToString(),R["Remark"].ToString());
        }
        public DataTable LoadTags_Table(TicketCount T)
        {
            List<TicketCount> L = new List<TicketCount>();
            DataTable _table = new DataTable();
            Ticket t = new Ticket();
            t.InventoryEventKey = ActiveEventId;
            T.Ticket = t;

            #region Table Setup
            _table.Columns.Add("Tag Counter", typeof(int));
            _table.Columns.Add("Item Number", typeof(string));
            _table.Columns.Add("Item Description", typeof(string));
            _table.Columns.Add("Class", typeof(string));
            _table.Columns.Add("UM", typeof(string));
            _table.Columns.Add("STK", typeof(string));
            _table.Columns.Add("Bin", typeof(string));
            _table.Columns.Add("IC", typeof(string));
            _table.Columns.Add("LotNumber", typeof(string));
            _table.Columns.Add("Verified", typeof(bool));
            _table.Columns.Add("Void", typeof(bool));
            _table.Columns.Add("Counted Qty", typeof(float));
            _table.Columns.Add("Re-Counted Qty", typeof(float));
            _table.Columns.Add("TicketKey", typeof(int));
            _table.Columns.Add("TicketCountKey", typeof(int));
            #endregion

            L = _ticketCountLogic.ReadByProp("Verified", T);

            foreach (TicketCount _t in L)
            {
                t = (Ticket)_ticketLogic.ReadbyId(_t.TicketKey).Result;
                _table.Rows.Add(
                    t.TicketCounter
                    , _t.ItemNumber
                    , _t.ItemDescription
                    , _t.ItemRef
                    , _t.UM
                    , _t.STK
                    , _t.BIN
                    , _t.IC
                    , _t.LotNumber
                    , _t.Verified
                    , _t.VoidTag
                    , _t.CountQty
                    , _t.ReCountQty
                    , t.TicketKey
                    , _t.TagCountKey
                    );
            }

            return _table;
        }
        public List<TicketCount> LoadTags_List(TicketCount T)
        {
            List<TicketCount> L = new List<TicketCount>();
            Ticket t = new Ticket();
            t.InventoryEventKey = ActiveEventId;
            T.Ticket = t;

            L = _ticketCountLogic.ReadByProp("Verified", T);
            //for (int i = 0; i < L.Count; i++)
            //{
            //    L[i].Ticket = (Ticket) _ticketLogic.ReadbyId(L[i].TicketKey).Result;
            //}
            return L;
        }
        public List<TicketCount> LoadTags_List(TicketCount T, string Range)
        {
            List<TicketCount> L = new List<TicketCount>();
            Ticket t = new Ticket();
            t.InventoryEventKey = ActiveEventId;
            T.Ticket = t;

            L = _ticketCountLogic.ReadByProp("Verified", T, Range);
            //for (int i = 0; i < L.Count; i++)
            //{
            //    L[i].Ticket = (Ticket) _ticketLogic.ReadbyId(L[i].TicketKey).Result;
            //}
            return L;
        }
        #endregion
    }
}
