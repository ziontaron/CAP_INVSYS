using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reusable;

namespace CAP_Inventory_System.Logic
{
    class UserLogic : ICRUD<User>
    {
        public CommonResponse Create(User e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.UserRoleKey != 0 && e.UserName.Length < 16)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    if (context.Users.FirstOrDefault(r => (r.UserName == e.UserName)) == null)
                    {
                        e.UserName = e.UserName.ToUpper();
                        context.Users.Add(e);
                        context.SaveChanges();
                        response.Success(e, "OK"); 
                        return response;
                    }
                    else
                    {
                        response.Error("User already exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Id can not be empty.", null);
                return response;
            }
        }
        public List<User> ReadAll()
        {
            using (CAPA_INVContext context = new CAPA_INVContext())
            {
                List<User> List = new List<User>();
                List = context.Users.ToList();
                return List;
            }
        }
        public CommonResponse ReadbyId(User e)
        {
            CommonResponse response = new CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Users.FirstOrDefault(r => r.UserKey == e.id);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Id was not found.", null);
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
        public CommonResponse ReadbyName(User e)
        {
            CommonResponse response = new CommonResponse();
            if (e.UserName != "")
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    e = context.Users.FirstOrDefault(r => r.UserName == e.UserName);
                    if (e != null)
                    {
                        response.Success(e, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User Name was not found.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Name can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Update(User e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    User entity = context.Users.FirstOrDefault(r => r.UserKey == e.id);

                    if (entity != null)
                    {
                        entity.UserName = e.UserName;
                        entity.UserRoleKey = e.UserRoleKey;
                        entity.Password = e.Password;
                        context.SaveChanges();
                        response.Success(entity, "OK");
                        return response;
                    }
                    else
                    {
                        response.Error("User does not exist.", null);
                        return response;
                    }
                }
            }
            else
            {
                response.Error("User Name or Description can not be empty.", null);
                return response;
            }
        }
        public CommonResponse Delete(User e)
        {
            CommonResponse response = new Reusable.CommonResponse();
            if (e.id > 0)
            {
                using (CAPA_INVContext context = new CAPA_INVContext())
                {
                    User entity = context.Users.FirstOrDefault(r => r.UserKey == e.id);
                    if (entity != null)
                    {
                        context.Users.Remove(entity);
                        context.SaveChanges();
                        response.Success();
                        return response;
                    }
                    else
                    {
                        response.Error("User ID can not be find.", null);
                        return response;
                    }
                }
            }
            response.Error("User ID can not be 0.", null);
            return response;
        }
    }
}
