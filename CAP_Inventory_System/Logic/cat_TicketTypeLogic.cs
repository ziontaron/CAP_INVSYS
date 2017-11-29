using Reusable;
using System.Linq;
using System;
using System.Collections.Generic;
using CAP_Inventory_System;

namespace CAP_Inventory_System.Logic
{
    class cat_TicketTypeLogic:ICRUD<cat_TicketType>
    {
        public CommonResponse Create(cat_TicketType e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketType != "" && e.TicketTypeDescirption != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.cat_TicketType.FirstOrDefault(r => r.TicketTypeKey == e.id) == null)
                    {
                        context.cat_TicketType.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
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
                response.Error("Ticket Category or Description can not be empty.", null);
                return response;
            }
        }       
        public List<cat_TicketType> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<cat_TicketType> List = new List<cat_TicketType>();
                List = context.cat_TicketType.ToList();
                return List;
            }
        }
        public CommonResponse ReadbyId(cat_TicketType e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.cat_TicketType.FirstOrDefault(r => r.TicketTypeKey == e.id);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Type ID was not found.", null);
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
        public CommonResponse ReadbyName(cat_TicketType e)
        {
            CommonResponse response = new CommonResponse();
            if (e.TicketType != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.cat_TicketType.FirstOrDefault(r => r.TicketType == e.TicketType);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Type Name was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Ticket Type Name can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Update(cat_TicketType e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketType != "" && e.TicketTypeDescirption != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    cat_TicketType entity = context.cat_TicketType.FirstOrDefault(r => r.TicketTypeKey == e.id);

                    if (entity != null)
                    {
                        entity.TicketType = e.TicketType;
                        entity.TicketTypeDescirption = e.TicketTypeDescirption;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Type does not exist.", null);
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
        public CommonResponse Delete(cat_TicketType e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    cat_TicketType entity = context.cat_TicketType.FirstOrDefault(r => r.TicketTypeKey == e.id);
                    if (entity != null)
                    {
                        context.cat_TicketType.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("Ticket Type ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("Ticket Type ID can not be 0.", null);
            return response;
        }
        public CommonResponse AddCountTicket(Ticket e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.TicketCounter != 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    cat_TicketType _cat_TicketType = context.cat_TicketType.FirstOrDefault(r => r.TicketType == "TicketCount");
                    Ticket _Ticket = context.Tickets.FirstOrDefault(r => (r.TicketCounter == e.TicketCounter && r.InventoryEventKey == e.InventoryEventKey));
                    if (_Ticket == null)
                    {
                        _cat_TicketType.Tickets.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
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
                response.Error("Ticket Category or Description can not be empty.", null);
                return response;
            }
        }
    }
}
