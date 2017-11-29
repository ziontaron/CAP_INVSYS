using System.Collections.Generic;
using System.Linq;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class MOTagHeaderLogic : ICRUD<MOTagHeader>
    {
        public CommonResponse Create(MOTagHeader e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey != 0 && e.MO != "" && e.MO_Ln != "" && e.MO != null && e.MO_Ln != null)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.MOTagHeaders.FirstOrDefault(r => (r.MO == e.MO && r.MO_Ln == e.MO_Ln)) == null)
                    {
                        context.MOTagHeaders.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Header already exist.", null);
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
        public List<MOTagHeader> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<MOTagHeader> List = new List<MOTagHeader>();
                List = context.MOTagHeaders.ToList();
                return List;
            }
        }       
        public CommonResponse ReadbyId(MOTagHeader e)
        {
            CommonResponse response = new CommonResponse();
            if (e.MOTagHeaderKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.MOTagHeaders.FirstOrDefault(r => r.Ticket.TicketKey == e.Ticket.TicketKey);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Header was not found.", null);
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
        public CommonResponse ReadbyName(MOTagHeader e)//by MO and Ln
        {
            CommonResponse response = new CommonResponse();
            if (e.MO != "" && e.MO_Ln != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.MOTagHeaders.FirstOrDefault(r => (r.MO == e.MO && r.MO_Ln == e.MO_Ln));
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Header was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("MO and Ln can not be empty.", null);
                return response;
            }
        }
        public CommonResponse ReadByCounter(int Counter,int Event_ID)
        {
            CommonResponse response = new Reusable.CommonResponse();
            Ticket e = new Ticket { TicketCounter = Counter, InventoryEventKey=Event_ID};
            MOTagHeader MT = new MOTagHeader();
            //e.TicketKey = ID;
            if (e.TicketCounter > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter && r.InventoryEventKey==e.InventoryEventKey));
                    MT = context.MOTagHeaders.FirstOrDefault(r => r.Ticket.TicketKey == e.TicketKey);
                    if (MT != null)
                    {
                        response.Success(MT, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Counter was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("MO Tag Counter can not be 0.", null);
                return response;
            }
        }
        public CommonResponse Update(MOTagHeader e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.MOTagHeaderKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    MOTagHeader entity = context.MOTagHeaders.FirstOrDefault(r => r.MOTagHeaderKey == e.MOTagHeaderKey);

                    if (entity != null)
                    {
                        entity.Planner = e.Planner;
                        entity.MO = e.MO;
                        entity.MO_Ln = e.MO_Ln;
                        entity.MO_Status = e.MO_Status;

                        entity.Order_Qty = e.Order_Qty;
                        entity.Recv_Qty = e.Recv_Qty;
                        entity.LineType = e.LineType;
                        entity.FG_Qty_in_WIP = e.FG_Qty_in_WIP;

                        entity.Parent_Item_NO = e.Parent_Item_NO;
                        entity.Parent_Item_Desc = e.Parent_Item_Desc;
                        entity.Parent_ItemRef1 = e.Parent_ItemRef1;

                        entity.CounterInitials = e.CounterInitials;
                        entity.CountedDate = e.CountedDate;

                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Header does not exist.", null);
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
        public CommonResponse Delete(MOTagHeader e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.MOTagHeaderKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    MOTagHeader entity = context.MOTagHeaders.FirstOrDefault(r => r.MOTagHeaderKey == e.MOTagHeaderKey);
                    if (entity != null)
                    {
                        context.MOTagHeaders.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Header ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("MO Tag Header ID can not be 0.", null);
            return response;
        }        
    }
}
