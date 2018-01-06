using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class FS_LocationMasterLogic : ICRUD<FS_LocationMaster>
    {
        public CommonResponse Create(FS_LocationMaster e)
        {
            CommonResponse response = new CommonResponse();

            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                FS_LocationMaster t = new FS_LocationMaster();
                t = context.FS_LocationMaster.FirstOrDefault(r => (r.FS_LocationMaster_Key == e.FS_LocationMaster_Key));
                //if (context.FS_ItemMaster.FirstOrDefault(r => (r.FS_ItemMaster_Key == e.FS_ItemMaster_Key)) == null)
                if (t == null)
                {
                    context.FS_LocationMaster.Add(e);
                    context.SaveChanges();
                    response.Success(e, "OK");
                    return response;
                }
                else
                {
                    response.Error("Location already exist.", null);
                    return response;
                }
            }
        }

        public CommonResponse Delete(FS_LocationMaster e)
        {
            throw new NotImplementedException();
        }

        public List<FS_LocationMaster> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<FS_LocationMaster> List = new List<FS_LocationMaster>();
                List = context.FS_LocationMaster.ToList();
                return List;
            }
        }

        public CommonResponse ReadbyId(FS_LocationMaster e)
        {
            throw new NotImplementedException();
        }

        public CommonResponse ReadbyName(FS_LocationMaster e)
        {
            throw new NotImplementedException();
        }

        public CommonResponse Update(FS_LocationMaster e)
        {
            throw new NotImplementedException();
        }

        public List<string> ReadAll_STK()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<string> L = new List<string>();
                List<FS_LocationMaster> List = new List<FS_LocationMaster>();

                List = context.FS_LocationMaster.ToList();
                foreach (FS_LocationMaster Loc in List)
                {
                    L.Add(Loc.STK);
                }
                return L.Distinct().ToList();
            }
        }
        public List<string> ReadAll_BIN()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<string> L = new List<string>();
                List<FS_LocationMaster> List = new List<FS_LocationMaster>();

                List = context.FS_LocationMaster.ToList();
                foreach (FS_LocationMaster Loc in List)
                {
                    L.Add(Loc.BIN);
                }
                return L.Distinct().ToList();
            }
        }
    }
}
