using System;
using System.Collections.Generic;
using System.Linq;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class InventoryEventLogic:ICRUD<InventoryEvent>
    {        
        public CommonResponse Create(InventoryEvent e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.InventoryEventName != "" && e.InventoryEventName != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.InventoryEvents.FirstOrDefault(r => r.InventoryEventName == e.InventoryEventName) == null)
                    {
                        context.InventoryEvents.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Inventory Event already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Inventory Event Name or Description can not be empty.", null);
                return response;
            }
        }
        public CommonResponse ReadbyName(InventoryEvent e)
        {
            CommonResponse response = new CommonResponse();
            if (e.InventoryEventName != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.InventoryEvents.FirstOrDefault(r => r.InventoryEventName == e.InventoryEventName);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Inventory Event Name was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Inventory Event Name can not be empty.", null);
                return response;
            }
        }
        public CommonResponse ReadbyId(InventoryEvent e)
        {
            CommonResponse response = new CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.InventoryEvents.FirstOrDefault(r => r.InventoryEventKey == e.id);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Inventory Event Id was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Inventory Event ID can not be 0.", null);
                return response;
            }
        }
        public List<InventoryEvent> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<InventoryEvent> List = new List<InventoryEvent>();
                List = context.InventoryEvents.ToList();
                return List;
            }
        }
        public CommonResponse Update(InventoryEvent e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.InventoryEventKey >0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    InventoryEvent entity = context.InventoryEvents.FirstOrDefault(r => r.InventoryEventKey == e.InventoryEventKey);

                    if (entity != null)
                    {
                        entity.InventoryEventName = e.InventoryEventName;
                        entity.InventoryEventDescription = e.InventoryEventDescription;
                        entity.Status = e.Status;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Inventory Event does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Inventory Event Name or Description can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(InventoryEvent e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    InventoryEvent entity = context.InventoryEvents.FirstOrDefault(r => r.InventoryEventKey == e.id);
                    if (entity != null)
                    {
                        try
                        {
                            context.InventoryEvents.Remove(entity);
                            context.SaveChanges();
                            response.Success();
                            return response;
                        }catch(Exception ex)
                        {
                            response.Error(ex.Message, null);
                            return response;
                        }
                    }
                    else
                    {
                        response.Error("Inventory Event ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("Inventory Event ID can not be 0.", null);
            return response;
        }
        public int QTYofTags(InventoryEvent e)
        {
            int Qty = 0;
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                //count = context.MyContainer
                //.Where(o => o.ID == '1')
                //.SelectMany(o => o.MyTable)
                //.Count()

                Qty = context.Tickets.Where(o => o.InventoryEventKey == e.InventoryEventKey).Count();
            }
            return Qty;
        }
        public Stadisticts EventStadistics(int EventId)
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                Stadisticts stats = new Stadisticts();
                
                stats.TicketCounts = context.TicketCounts.Where(r => (r.Ticket.InventoryEventKey == EventId)).Count();
                stats.TicketBlank = context.TicketCounts.Where(r => (r.BlankTag == true) && (r.Ticket.InventoryEventKey == EventId)).Count();
                stats.TicketVerified = context.TicketCounts.Where(r => (r.Verified == true) && (r.Ticket.InventoryEventKey == EventId)).Count();
                stats.TicketVoid = context.TicketCounts.Where(r => (r.VoidTag == true) && (r.Ticket.InventoryEventKey == EventId)).Count();
                stats.TicketCounted = context.TicketCounts.Where(r => (r.CountQty > 0 || r.ReCountQty > 0) && (r.Ticket.InventoryEventKey == EventId)).Count();

                if (stats.TicketCounts > 0)
                {
                    stats.TicketCountedPorcentage = (stats.TicketCounted *100)/ stats.TicketCounts;
                }
                //Where(r => (r.TicketKey == Ticket_Id && r.Ticket.cat_TicketTypeKey == 1)).ToList();
                //return List;
                return stats;
            }
        }
    }
}
