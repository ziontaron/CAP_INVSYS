using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;


namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region MO Tag Header
        public int CreateMOHeaderTag(MOTag MT)
        {
            Ticket _ticket = new Ticket();
            MOTagHeader _moTagHeader = new MOTagHeader();
            cat_TicketType cat = (cat_TicketType)_cat_TicketTypeLogic.ReadbyName(new cat_TicketType("MOTagHeader")).Result;
            int counter = GetLastCounter();

            _ticket.cat_TicketTypeKey = cat.id;
            _ticket.InventoryEventKey = ActiveEventId;
            _ticket.TicketCounter = counter+1;
            //_ticket.TicketCounter = MT.Counter;

            _moTagHeader.Planner = MT.Planner;
            _moTagHeader.MO = MT.MO;
            _moTagHeader.MO_Ln = MT.MO_Ln;
            _moTagHeader.MO_Status = MT.MO_Status;
            _moTagHeader.Order_Qty = MT.Order_Qty;
            _moTagHeader.Recv_Qty = MT.Recv_Qty;
            _moTagHeader.LineType = MT.LineType;
            _moTagHeader.FG_Qty_in_WIP = 0;

            _moTagHeader.Parent_Item_NO = MT.Parent_Item_NO;
            _moTagHeader.Parent_Item_Desc = MT.Parent_Item_Desc;
            _moTagHeader.Parent_ItemRef1 = MT.Parent_ItemRef1;
            
            _ticket.MOTagHeaders.Add(_moTagHeader);
            _ticket=(Ticket)(_ticketLogic.Create(_ticket).Result as Ticket);
            return _ticket.TicketCounter;

        }
        public void UpdateMOHeaderTag(MOTag MT)
        {
            MOTagHeader _MOTagHeader = new MOTagHeader();
            _MOTagHeader = MOTag2Entity(MT);
            _moTagHeaderLogic.Update(_MOTagHeader);
        }
        public MOTag LoadMOHeaderTag(int Counter)
        {
            MOTag _MOTag = new MOTag();
            MOTagHeader _MOTagHeader = new MOTagHeader();
            Ticket _Ticket = new Ticket();

            _Ticket = (Ticket)_ticketLogic.ReadbyName(Counter,ActiveEventId).Result;
            //List< MOTagHeader> _MOTags= _Ticket.MOTagHeaders;

            _MOTagHeader.Ticket = _Ticket;
            _MOTagHeader = (MOTagHeader)_moTagHeaderLogic.ReadByCounter(Counter,ActiveEventId).Result;
            _MOTag = Entity2MOTag(_MOTagHeader);
            return _MOTag;
        }
        public DataTable MOTagHeaders2Table()
        {
            DataTable _MTDT = new DataTable();

            //-----------HEADER--------------------//
            _MTDT.Columns.Add("Counter", typeof(int));
            _MTDT.Columns.Add("Planner", typeof(string));
            _MTDT.Columns.Add("MO", typeof(string));
            _MTDT.Columns.Add("MO_Ln", typeof(string));
            _MTDT.Columns.Add("MO_Status", typeof(string));
            _MTDT.Columns.Add("Order_Qty", typeof(int));
            _MTDT.Columns.Add("Recv_Qty", typeof(int));
            _MTDT.Columns.Add("LineType", typeof(string));
            _MTDT.Columns.Add("FGinWip", typeof(int));

            //-----------TITTLE--------------------//
            _MTDT.Columns.Add("Parent_Item_NO", typeof(string));
            _MTDT.Columns.Add("Parent_Item_Desc", typeof(string));
            _MTDT.Columns.Add("Parent_ItemRef1", typeof(string));

            //-----------FOOTER--------------------//  
            _MTDT.Columns.Add("CounterInitials", typeof(string));
            _MTDT.Columns.Add("CountedDate", typeof(DateTime));

            //-----------Keys----------------------//
            _MTDT.Columns.Add("MOTagKey", typeof(int));
            _MTDT.Columns.Add("TicketID", typeof(int));

            List<MOTagHeader> _MOList = _moTagHeaderLogic.ReadAll();
            MOTag _MT = new MOTag();

            for (int i = 0; i < _MOList.Count; i++)
            {
                _MT = Entity2MOTag(_MOList[i]);               
                _MTDT.Rows.Add(_MT.Counter
                    , _MT.Planner
                    , _MT.MO
                    , _MT.MO_Ln
                    , _MT.MO_Status
                    , _MT.Order_Qty
                    , _MT.Recv_Qty
                    , _MT.LineType
                    , _MT.FGinWip
                    , _MT.Parent_Item_NO
                    , _MT.Parent_Item_Desc
                    , _MT.Parent_Item_NO
                    , _MT.CounterInitials
                    , _MT.CountedDate
                    , _MT.MOTagID
                    , _MT.TicketID);
            }
            return _MTDT;
        }
        #endregion
    }
}
