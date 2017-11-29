using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        cat_UserRole UserRole = new cat_UserRole();
        public List<string> ReadAllRoles()
        {
            List<string> UserRoles = new List<string>();
            List<cat_UserRole> UserRole_l= _cat_UserRoleLogic.ReadAll();
            foreach (cat_UserRole UR in UserRole_l)
            {
                UserRoles.Add(UR.UserRole);
            }

            return UserRoles;
        }
    }
}
