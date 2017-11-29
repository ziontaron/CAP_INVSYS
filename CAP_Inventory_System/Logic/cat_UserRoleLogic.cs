using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class cat_UserRoleLogic : ICRUD<cat_UserRole>
    {
        public CommonResponse Create(cat_UserRole e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.UserRole != "" && e.UserRoleDesc != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.cat_UserRole.FirstOrDefault(r => r.UserRole == e.UserRole) == null)
                    {
                        context.cat_UserRole.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Role already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Role or Description can not be empty.", null);
                return response;
            }
        }
        public List<cat_UserRole> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<cat_UserRole> List = new List<cat_UserRole>();
                List = context.cat_UserRole.ToList();
                return List;
            }
        }
        public CommonResponse ReadbyId(cat_UserRole e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.UserRoleKey > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.cat_UserRole.FirstOrDefault(r => r.UserRoleKey == e.id);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Role ID was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Role ID can not be 0.", null);
                return response;
            }
        }        
        public CommonResponse ReadbyName(cat_UserRole e)
        {
            CommonResponse response = new CommonResponse();
            if (e.UserRole != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.cat_UserRole.FirstOrDefault(r => r.UserRole == e.UserRole);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Role Name was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Role Name can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(cat_UserRole e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.UserRole != "" && e.UserRoleDesc != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    cat_UserRole entity = context.cat_UserRole.FirstOrDefault(r => r.UserRoleKey == e.id);

                    if (entity != null)
                    {
                        entity.UserRole = e.UserRole;
                        entity.UserRoleDesc = e.UserRoleDesc;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Role does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Role or Description can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Update(cat_UserRole e)
        {
            CommonResponse response = new CommonResponse();
            if (e.UserRole != "" && e.UserRoleDesc != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    cat_UserRole entity = context.cat_UserRole.FirstOrDefault(r => r.UserRoleKey == e.UserRoleKey);

                    if (entity != null)
                    {
                        entity.UserRole = e.UserRole;
                        entity.UserRoleDesc = e.UserRole;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Role does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Role or Description can not be empty.", null);
                return response;
            }
        }
}
}
