using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Inventory Event Functions
        public void UpdateActiveInventoryEvent(InventoryEvent x)
        {
            _ActiveInventoryEvent = x;
        }
        public void CreateInventoryEvent(string Event_Name, string Event_Description)
        {
            InventoryEvent entity = new InventoryEvent
            {
                InventoryEventName = Event_Name,
                InventoryEventDescription = Event_Description,
                CreationDate = DateTime.Now,
                Status = true
            };
            _Response = _inventoryEventLogic.Create(entity);
            UpdateActiveInventoryEvent((InventoryEvent)_Response.Result);            
        }
        public void ReadInventoryEventByName(string Event_Name)
        {
            InventoryEvent entity = new InventoryEvent
            {
                InventoryEventName = Event_Name
            };
            _Response = _inventoryEventLogic.ReadbyName(entity);
            _ActiveInventoryEvent = (InventoryEvent)_Response.Result;
        }
        public void ReadInventoryEventById(int Event_Id)
        {
            InventoryEvent entity = new InventoryEvent
            {
                InventoryEventKey = Event_Id
            };
            _Response = _inventoryEventLogic.ReadbyId(entity);
            _ActiveInventoryEvent = (InventoryEvent)_Response.Result;
        }
        public List<string> ReadAllInventoryEvents()
        {
            List<string> L = new List<string>();
            foreach (InventoryEvent IE in _inventoryEventLogic.ReadAll())
            {
                L.Add(IE.InventoryEventName);
            }
            return L;
        }
        public void UpdateInventoryEvent(int Event_Key, string Event_Name, string Event_Description
            , bool Event_Status, bool TicketCountLoded, bool MOTags)
        {
            InventoryEvent entity = new InventoryEvent
            {
                InventoryEventKey = Event_Key,
                InventoryEventName = Event_Name,
                InventoryEventDescription = Event_Description,
                Status = Event_Status,
                TicketCountTags = TicketCountLoded,
                MOTags= MOTags
            };
            _Response = _inventoryEventLogic.Update(entity);
            UpdateActiveInventoryEvent((InventoryEvent)_Response.Result);
        }
        public void DeleteInventoryEvent(int Event_Key)
        {
            InventoryEvent entity = new InventoryEvent { InventoryEventKey = Event_Key };
            CommonResponse result = _inventoryEventLogic.Delete(entity);
        }
        public int QTYofTags(int Event_Key)
        {
            InventoryEvent entity = new InventoryEvent { InventoryEventKey = Event_Key };

            return _inventoryEventLogic.QTYofTags(entity);

        }
        public List<string> LoadEvents()
        {
            List<string> L = new List<string>();
            foreach (string t in ReadAllInventoryEvents())
            {
                L.Add(t);
            }
            return L;
        }
        #endregion
    }
}
