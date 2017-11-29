using System;
using System.Collections.Generic;
using System.Linq;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    public class TicketCountLogic : ICRUD<TicketCount>
    {
        public CommonResponse Create(TicketCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey != 0 )
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.TicketCounts.FirstOrDefault(r => (r.id == e.id)) == null)
                    {
                        context.TicketCounts.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Count already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Id can not be empty.", null);
                return response;
            }
        }
        public List<TicketCount> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<TicketCount> List = new List<TicketCount>();
                List = context.TicketCounts.ToList();
                return List;
            }
        }
        public List<TicketCount> ReadAll(int Ticket_Id)
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<TicketCount> List = new List<TicketCount>();
                List = context.TicketCounts.Where(r => (r.TicketKey == Ticket_Id&& r.Ticket.cat_TicketTypeKey == 1)).ToList();
                return List;
            }
        }
        public CommonResponse ReadbyId(TicketCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey > 0 && e.TagCountKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.TicketCounts.FirstOrDefault(r => (r.TagCountKey == e.TagCountKey && r.Ticket.cat_TicketTypeKey==2));
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Count ID was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Count ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse ReadbyName(TicketCount e)
        {
            CommonResponse response = new CommonResponse();
            if (e.ItemNumber != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.TicketCounts.FirstOrDefault(r => r.ItemNumber == e.ItemNumber);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Counter was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Counter can not be 0.", null);
                return response;
            }
        }//by PN
        public CommonResponse Update(TicketCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey != 0 && e.TagCountKey != 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    TicketCount entity = context.TicketCounts.FirstOrDefault(r => (r.TicketKey == e.TicketKey 
                    && r.TagCountKey == e.TagCountKey));
                    if (entity != null)
                    {
                        UpdateEntity(ref entity, e);
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(TicketCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey > 0 && e.TagCountKey>0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    TicketCount entity = context.TicketCounts.FirstOrDefault(r => (r.TicketKey == e.TicketKey
                    && r.TagCountKey == e.TagCountKey));
                    if (entity != null)
                    {
                        context.TicketCounts.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("Ticket ID can not be 0.", null);
            return response;
        }
        private void UpdateEntity(ref TicketCount CE, TicketCount E)
        {
            if (E.VoidTag)
            {
                CE.VoidTag = true;
            }
            else
            {
                if (E.BlankTag)
                {
                    CE.ItemNumber = E.ItemNumber;
                    CE.ItemDescription = E.ItemDescription;
                    CE.ItemRef = E.ItemRef;
                    CE.UM = E.UM;
                    CE.BIN = E.BIN;
                    CE.SKT = E.SKT;
                    CE.IC = E.IC;
                    CE.InventoryQty = E.InventoryQty;
                    CE.LotNumber = E.LotNumber;

                    CE.CountQty = E.CountQty;
                    CE.ReCountQty = E.ReCountQty;
                    CE.Verified = E.Verified;
                    CE.CounterInitials = E.CounterInitials;
                    CE.CountedDate = E.CountedDate;
                    CE.VoidTag = E.VoidTag;
                    CE.ItemNumber_FSKey = E.ItemNumber_FSKey;
                }
                else
                {
                    CE.CountQty = E.CountQty;
                    CE.ReCountQty = E.ReCountQty;
                    CE.Verified = E.Verified;
                    CE.CounterInitials = E.CounterInitials;
                    CE.CountedDate = E.CountedDate;
                    CE.VoidTag = E.VoidTag;
                }
            }
        }
    }
}
