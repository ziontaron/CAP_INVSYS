using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class MOTagCountLogic : ICRUD<MOTagCount>
    {
        public CommonResponse Create(MOTagCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.MOTagHeaderKey != 0 && e.Component_No != "" && e.Component_Desc != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.MOTagHeaders.FirstOrDefault(r => (r.MOTagHeaderKey == e.MOTagHeaderKey)) != null)
                    {
                        context.MOTagCounts.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Count already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Component Name or Description can not be empty.", null);
                return response;
            }
        }
        public List<MOTagCount> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<MOTagCount> List = new List<MOTagCount>();
                List = context.MOTagCounts.ToList();
                return List;
            }
        }
        public List<MOTagCount> ReadAll(int MOTagHeaderID)
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<MOTagCount> List = new List<MOTagCount>();
                List = context.MOTagCounts.Where(r=> r.MOTagHeaderKey==MOTagHeaderID).ToList();
                return List;
            }
        }
        public CommonResponse ReadbyName(MOTagCount e)
        {
            CommonResponse response = new CommonResponse();
            if (e.Component_No != "" )
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.MOTagCounts.FirstOrDefault(r => (r.Component_No == e.Component_No));
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Line was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Component can not be empty.", null);
                return response;
            }
        }
        public CommonResponse ReadbyId(MOTagCount e)
        {
            CommonResponse response = new CommonResponse();
            if (e.MOTagHeaderKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.MOTagCounts.FirstOrDefault(r => r.MOTagHeaderKey == e.MOTagHeaderKey);
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
        public CommonResponse Update(MOTagCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.MOTagCountKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    MOTagCount entity = context.MOTagCounts.FirstOrDefault(r => r.MOTagCountKey == e.MOTagCountKey);

                    if (entity != null)
                    {
                        entity.SeqNum = e.SeqNum;
                        entity.Component_No = e.Component_No;
                        entity.Component_Desc = e.Component_Desc;
                        entity.UM = e.UM;

                        entity.Qty_Per = e.Qty_Per;
                        entity.Issued_Qty = e.Issued_Qty;
                        entity.LooseCountQty = e.LooseCountQty;
                        entity.LooseReCountQty = e.LooseReCountQty;

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
        public CommonResponse Delete(MOTagCount e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.MOTagHeaderKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    MOTagCount entity = context.MOTagCounts.FirstOrDefault(r => r.MOTagCountKey == e.MOTagCountKey);
                    if (entity != null)
                    {
                        context.MOTagCounts.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("MO Tag Line ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("MO Tag Line ID can not be 0.", null);
            return response;
        }
    }
}
