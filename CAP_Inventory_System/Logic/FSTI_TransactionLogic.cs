using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class FSTI_TransactionLogic : ICRUD<FSTI_Transactions>
    {
        public CommonResponse Create(FSTI_Transactions e)
        {
            CommonResponse response = new CommonResponse();
            
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                FSTI_Transactions t = new FSTI_Transactions();
                t = context.FSTI_Transactions.FirstOrDefault(r => (r.TagCountKey == e.TagCountKey));
                if (t == null)
                {
                    e.DateStampIn = DateTime.Now;
                    context.FSTI_Transactions.Add(e);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        response.Error("Exception: "+ex.Message, null);
                        return response;
                    }

                    response.Success(e, "OK");
                    return response;
                }
                else
                {
                    response.Error("FSTI Transaction already exist.", null);
                    return response;
                }
            }

        }
        public List<FSTI_Transactions> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<FSTI_Transactions> List = new List<FSTI_Transactions>();
                List = context.FSTI_Transactions.ToList();
                return List;
            }
        }        
        public CommonResponse ReadbyId(FSTI_Transactions e)
        {
            CommonResponse response = new CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.FSTI_Transactions.FirstOrDefault(r => r.FSTI_Transaction_key == e.FSTI_Transaction_key);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("FSTI Transactions Id was not found.", null);
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
        public CommonResponse ReadbyName(FSTI_Transactions e)
        {
            CommonResponse response = new CommonResponse();
            if (e.FS_PartNo != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.FSTI_Transactions.FirstOrDefault(r => r.FS_PartNo == e.FS_PartNo);
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
        public CommonResponse Update(FSTI_Transactions e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.FSTI_Transaction_key > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    FSTI_Transactions entity = context.FSTI_Transactions.FirstOrDefault(r => r.FSTI_Transaction_key == e.FSTI_Transaction_key);

                    if (entity != null)
                    {
                        entity.TransactionStringFields = e.TransactionStringFields;
                        entity.TransactionProcessedYN = e.TransactionProcessedYN;
                        entity.FSResponse = e.FSResponse;
                        entity.FSError = e.FSError;
                        entity.DateStampOut = e.DateStampOut;
                        //entity.Password = e.Password;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("FSTI Transaction does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("FSTI Transaction key can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(FSTI_Transactions e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.FSTI_Transaction_key > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    FSTI_Transactions entity = context.FSTI_Transactions.FirstOrDefault(r => r.FSTI_Transaction_key == e.FSTI_Transaction_key);
                    if (entity != null)
                    {
                        context.FSTI_Transactions.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("FSTI Transactions ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("Item ID can not be 0.", null);
            return response;
        }
    }
}
