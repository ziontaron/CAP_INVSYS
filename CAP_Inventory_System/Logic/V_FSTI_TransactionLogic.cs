using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class V_FSTI_TransactionLogic : ICRUD<V_FSTI_Transaction>
    {
        public CommonResponse Create(V_FSTI_Transaction e)
        {
            throw new NotImplementedException();
        }
        public CommonResponse Delete(V_FSTI_Transaction e)
        {
            throw new NotImplementedException();
        }

        public List<V_FSTI_Transaction> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<V_FSTI_Transaction> List = new List<V_FSTI_Transaction>();
                List = context.V_FSTI_Transaction.ToList();
                return List;
            }
        }
        public List<V_FSTI_Transaction> ReadAll(int InventoryEventKey)
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<V_FSTI_Transaction> List = new List<V_FSTI_Transaction>();
                try
                {
                    List = context.V_FSTI_Transaction.Where(r => r.InventoryEventKey == InventoryEventKey).ToList();
                }
                catch(Exception ex)
                {
                    string message = ex.Message;
                    return null;
                }
                return List;
            }
        }
        public CommonResponse ReadbyId(V_FSTI_Transaction e)
        {
            CommonResponse response = new CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.V_FSTI_Transaction.FirstOrDefault(r => r.FSTI_Transaction_key == e.id);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Transaction Id was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Transaction ID can not be 0.", null);
                return response;
            }
        }
        public CommonResponse ReadbyName(V_FSTI_Transaction e)
        {
            CommonResponse response = new CommonResponse();
            if (e.TransactionStringFields !="")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.V_FSTI_Transaction.FirstOrDefault(r => r.TransactionStringFields.Contains(e.TransactionStringFields));
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("Transaction Field was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("Transaction Field can not be empty.", null);
                return response;
            }
        }

        public CommonResponse Update(V_FSTI_Transaction e)
        {
            throw new NotImplementedException();
        }
    }
}
