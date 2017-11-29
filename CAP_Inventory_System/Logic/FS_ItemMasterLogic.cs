using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class FS_ItemMasterLogic : ICRUD<FS_ItemMaster>
    {
        public CommonResponse Create(FS_ItemMaster e)
        {
            CommonResponse response = new CommonResponse();

            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                FS_ItemMaster t = new FS_ItemMaster();
                t = context.FS_ItemMaster.FirstOrDefault(r => (r.ItemNumber_FSKey == e.ItemNumber_FSKey));
                //if (context.FS_ItemMaster.FirstOrDefault(r => (r.FS_ItemMaster_Key == e.FS_ItemMaster_Key)) == null)
                if (t == null)
                {
                context.FS_ItemMaster.Add(e);
                context.SaveChanges();
                response.Success(e, "OK");
                return response;
                }
                else
                {
                    response.Error("Item already exist.", null);
                    return response;
                }
            }            
        }
        public List<FS_ItemMaster> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<FS_ItemMaster> List = new List<FS_ItemMaster>();
                List = context.FS_ItemMaster.ToList();
                return List;
            }
        }
        public CommonResponse ReadbyId(FS_ItemMaster e) // FS ID
        {
            CommonResponse response = new CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.FS_ItemMaster.FirstOrDefault(r => r.ItemNumber_FSKey == e.ItemNumber_FSKey);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Item Id was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse ReadbyName(FS_ItemMaster e)
        {
            CommonResponse response = new CommonResponse();
            if (e.ItemNumber != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.FS_ItemMaster.FirstOrDefault(r => r.ItemNumber == e.ItemNumber);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("ItemNumber was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("ItemNumber can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Update(FS_ItemMaster e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.ItemNumber_FSKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    FS_ItemMaster entity = context.FS_ItemMaster.FirstOrDefault(r => r.ItemNumber_FSKey == e.ItemNumber_FSKey);

                    if (entity != null)
                    {
                        //entity.UserName = e.UserName;
                        //entity.UserRoleKey = e.UserRoleKey;
                        //entity.Password = e.Password;
                        //context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Item does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Item can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(FS_ItemMaster e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.ItemNumber_FSKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    FS_ItemMaster entity = context.FS_ItemMaster.FirstOrDefault(r => r.ItemNumber_FSKey == e.ItemNumber_FSKey);
                    if (entity != null)
                    {
                        context.FS_ItemMaster.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("Item ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("Item ID can not be 0.", null);
            return response;
        }
    }
}
