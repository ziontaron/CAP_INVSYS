using System;
using System.Collections.Generic;
using System.Linq;
using Reusable;
using System.Data;

namespace CAP_Inventory_System.Logic
{
    class TicketLogic : ICRUD<Ticket>
    {
        //private readonly CAPA_INVContext _context;
        //public TicketLogic(CAPA_INVContext lcontext)
        //{
        //    _context = lcontext;
        //}
        public TicketLogic()
        {
            
        }

        public CommonResponse Create(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketCounter != 0 && e.InventoryEventKey != 0 && e.TicketCounter!=0 && e.TicketCounter!=0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter)
                    && (r.InventoryEventKey == e.InventoryEventKey)) == null)
                    {
                        context.Tickets.Add(e);
                        try
                        {
                            context.SaveChanges();
                            response.Success(e, "OK");
                        }
                        catch(Exception ex)
                        {
                            response.Error(ex.Message, null);
                        }
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Category already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket TicketCounter or InventoryEventKey can not be empty.", null);
                return response;
            }
        }
        public List<Ticket> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<Ticket> List = new List<Ticket>();
                List = context.Tickets.ToList();
                return List;
            }
        }
        public List<Ticket> ReadAll(int InventoryEvent_Id)
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<Ticket> List = new List<Ticket>();
                List = context.Tickets.Where(r => r.InventoryEventKey == InventoryEvent_Id).ToList();
                return List;
            }
        }        
        public CommonResponse ReadbyId(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => r.TicketKey == e.TicketKey);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket ID was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Type ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse ReadbyId(int ID)
        {
            CommonResponse response = new Reusable.CommonResponse();
            Ticket e = new Ticket { TicketKey=ID};
            //e.TicketKey = ID;
            if (e.TicketKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => r.TicketKey == e.TicketKey);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket ID was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Type ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse ReadbyName(Ticket e)///by counter
        {
            CommonResponse response = new CommonResponse();
            if (e.TicketCounter != 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter && r.InventoryEventKey == e.InventoryEventKey));
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
        }//by COUNTER
        public CommonResponse ReadbyName(int Counter, int Active_IE_Key)///by counter
        {
            Ticket e = new CAP_Inventory_System.Ticket { TicketCounter = Counter,InventoryEventKey=Active_IE_Key };
            CommonResponse response = new CommonResponse();
            if (e.TicketCounter != 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter && r.InventoryEventKey == e.InventoryEventKey));
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
        }//by COUNTER
        public CommonResponse Update(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey != 0 && e.InventoryEventKey != 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    Ticket entity = context.Tickets.FirstOrDefault(r => r.TicketKey == e.TicketKey);

                    if (entity != null)
                    {
                        entity = e;
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
                response.Error("Ticket Type or Description can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    Ticket entity = context.Tickets.FirstOrDefault(r => r.TicketKey == e.TicketKey);
                    if (entity != null)
                    {
                        context.Tickets.Remove(entity);
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
        public CommonResponse GetbyTagNo(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            //e.TicketKey = ID;
            if (e.TicketCounter > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter && r.InventoryEventKey== e.InventoryEventKey));
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket ID was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Type ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse GetLastTagID(Ticket e)
        {
            CommonResponse response = new CommonResponse();
            using (CAPA_INVContext context = new CAPA_INVContext())
            {

                int? TagCounter;

                try
                {
                    TagCounter = context.Tickets.Where(q => q.InventoryEventKey == e.InventoryEventKey).Max(r => r.TicketCounter);
                }
                catch
                {
                    TagCounter = 0;
                }

                //Ticket _ticket = context.Tickets.Max(r => r.TicketCounter);
                if (TagCounter != null && TagCounter > 0)
                {
                    e.TicketCounter = Convert.ToInt32(TagCounter);
                    e = (Ticket)GetbyTagNo(e).Result;
                    response.Success(e, "OK");
                    return response;
                }
                else
                {
                    response.Error("Ticket ID was not found.", null);
                    return response;
                }
            }
        }
    }
}
