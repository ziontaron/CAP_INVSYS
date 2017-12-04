using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Tickets Functions
        public void CreateBlankCountTiket()
        {
            if (ActiveEventId != 0)
            {
                Ticket _ticket = new Ticket();
                cat_TicketTypeLogic _cat_TicketTypeLogic = new cat_TicketTypeLogic();
                cat_TicketType cat = (cat_TicketType)_cat_TicketTypeLogic.ReadbyName(new cat_TicketType("TicketCount")).Result;

                TicketCount _tag = new TicketCount();

                Ticket LastTag = new Ticket();
                LastTag.InventoryEventKey = ActiveEventId;
                LastTag = (Ticket)_ticketLogic.GetLastTagID(LastTag).Result;
                //LastTag.InventoryEventKey = ActiveEventId;
                //LastTag = (Ticket)_ticketLogic.ReadbyId(LastTag).Result;

                _ticket.cat_TicketTypeKey = cat.id;
                _ticket.InventoryEventKey = ActiveEventId;
                //_ticket.TicketCounter = T.Counter;
                _ticket.TicketCounter = LastTag.TicketCounter + 1;

                _tag.ItemNumber = "";
                _tag.ItemDescription = "";
                _tag.ItemRef = "";
                _tag.UM = "";
                _tag.STK = "";
                _tag.BIN = "";
                _tag.IC = "";
                _tag.InventoryQty = 0;
                _tag.LotNumber = "";
                _tag.BlankTag = true;

                _ticket.TicketCounts.Add(_tag);

                //_cat_TicketTypeLogic.AddCountTicket(_ticket);
                _ticketLogic.Create(_ticket);
            }
        }
        public void CreateBlankBatch(int BlankQty)
        {
            if (ActiveEventId != 0)
            {
                int counter = 0; Ticket _ticket = new Ticket();
                cat_TicketTypeLogic _cat_TicketTypeLogic = new cat_TicketTypeLogic();
                cat_TicketType cat = (cat_TicketType)_cat_TicketTypeLogic.ReadbyName(new cat_TicketType("TicketCount")).Result;

                TicketCount _tag = new TicketCount();

                Ticket LastTag = new Ticket();
                LastTag.InventoryEventKey = ActiveEventId;
                LastTag = (Ticket)_ticketLogic.GetLastTagID(LastTag).Result;
                if (LastTag != null)
                {
                    counter = LastTag.TicketCounter;
                }
                else
                {
                    counter = 0;
                }
                for (int i = 1; i <= BlankQty; i++)
                {
                    _ticket.cat_TicketTypeKey = cat.id;
                    _ticket.InventoryEventKey = ActiveEventId;
                    //_ticket.TicketCounter = T.Counter;
                    _ticket.TicketCounter = counter + i;

                    _tag.ItemNumber = "";
                    _tag.ItemDescription = "";
                    _tag.ItemRef = "";
                    _tag.UM = "";
                    _tag.STK = "";
                    _tag.BIN = "";
                    _tag.IC = "";
                    _tag.InventoryQty = 0;
                    _tag.LotNumber = "";
                    _tag.BlankTag = true;

                    _ticket.TicketCounts.Add(_tag);

                    //_cat_TicketTypeLogic.AddCountTicket(_ticket);
                    _ticketLogic.Create(_ticket);
                }
            }
        }
        public void CreateCountTiket(TicketTag T)
        {
            if (ActiveEventId != 0)
            {
                Ticket _ticket = new Ticket();
                cat_TicketTypeLogic _cat_TicketTypeLogic = new cat_TicketTypeLogic();
                cat_TicketType cat = (cat_TicketType)_cat_TicketTypeLogic.ReadbyName(new cat_TicketType("TicketCount")).Result;
                TicketCount _tag = new TicketCount();

                _ticket.cat_TicketTypeKey = cat.id;
                _ticket.InventoryEventKey = ActiveEventId;
                _ticket.TicketCounter = T.Counter;

                _tag.ItemNumber = T.ItemNumber;
                _tag.ItemDescription = T.ItemDescription;
                _tag.ItemRef = T.ItemReference1;
                _tag.UM = T.ItemUM;
                _tag.STK = T.Stockroom;
                _tag.BIN = T.Bin;
                _tag.IC = T.InventoryCategory;
                _tag.InventoryQty = T.InventoryQuantity;
                _tag.LotNumber = T.LotNumber;
                _tag.ItemNumber_FSKey = T.ItemNumber_FSKey;

                _ticket.TicketCounts.Add(_tag);

                //_cat_TicketTypeLogic.AddCountTicket(_ticket);
                _ticketLogic.Create(_ticket);
            }
        }
        public TicketTag LoadTag(int Counter)
        {
            TicketTag _ticketTag = new TicketTag();
            TicketCount _ticketCount = new TicketCount();
            TicketCountLogic _ticketCountLogic = new TicketCountLogic();
            Ticket _ticket = new Ticket();
            TicketLogic _ticketLogic = new TicketLogic();
            _ticket.InventoryEventKey = ActiveEventId;
            _ticket.TicketCounter = Counter;

            _ticket = (Ticket)_ticketLogic.ReadbyName(_ticket).Result;

            //_ticketCount.Ticket = _ticket;
            if (_ticket != null)
            {
                if (_ticket.cat_TicketTypeKey == 1)
                {
                    if (_ticketCountLogic.ReadAll(_ticket.TicketKey).Count > 0)
                    {
                        _ticketCount = _ticketCountLogic.ReadAll(_ticket.TicketKey)[0];
                        _ticketCount.Ticket = _ticket;

                        //if (_ticket.TicketCounts.Count > 0)
                        //{
                        //    _ticketCount = (TicketCount)_ticket.TicketCounts;
                        //}

                        //_ticketCount = _ticketCountLogic.ReadAll(_ticket.TicketKey)[0];

                        _ticketTag = Entity2Tag(_ticketCount);
                        return _ticketTag;
                    }
                }
            }
            return null;
        }
        public void UpdateTag(TicketTag T)
        {
            TicketCount _ticketCount = new TicketCount();
            TicketCountLogic _ticketCountLogic = new Logic.TicketCountLogic();

            _ticketCount = Tag2Entity(T);
            _Response = _ticketCountLogic.Update(_ticketCount);
        }
        #endregion
    }
}
