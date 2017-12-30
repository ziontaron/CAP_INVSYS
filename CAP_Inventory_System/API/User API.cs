using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        UserLogic _userLogic = new UserLogic();
        User _user = new User();
        public void CreateUser(string UserName, string UserPassword, string UserRole )
        {
            cat_UserRole _userRole = (cat_UserRole)(_cat_UserRoleLogic.ReadbyName(new cat_UserRole { UserRole = UserRole }).Result);
            _userLogic.Create(new User
            {
                UserName = UserName,
                Password = UserPassword,
                UserRoleKey = _userRole.UserRoleKey
            });
        }
        public void DeleteUser(string UserName)
        {
            _user = new User { UserName = UserName };
            _user = (User)_userLogic.ReadbyName(_user).Result;
            if (_user != null)
            {
                _userLogic.Delete(_user);
            }
        }
        public string ReadUser(string _UserName, string _UserPAssword)
        {
            string UserRole = "";
            _user = new User { UserName = _UserName, Password = _UserPAssword };
            _user = (User)_userLogic.ReadbyName(_user).Result;
            if (_user != null)
            {
                cat_UserRole _cat = new cat_UserRole { UserRoleKey = _user.UserRoleKey };
                _cat = (cat_UserRole)_cat_UserRoleLogic.ReadbyId(_cat).Result;
                _userName = _UserName;
                _userProfile = _cat.UserRole;
                return _cat.UserRole;
            }
            return UserRole;
        }
        public DataTable ReadAllUsers()
        {
            DataTable Users_t = new DataTable();

            Users_t.Columns.Add("UserId", typeof(int));
            Users_t.Columns.Add("UserName", typeof(string));
            Users_t.Columns.Add("UserRole", typeof(string));

            List<User> L_Users = _userLogic.ReadAll();

            foreach (User U in L_Users)
            {
                cat_UserRole UserRole = new cat_UserRole { UserRoleKey = U.UserRoleKey };
                UserRole = (cat_UserRole)_cat_UserRoleLogic.ReadbyId(UserRole).Result;
                Users_t.Rows.Add(U.id, U.UserName, UserRole.UserRole);
            }

            return Users_t;
        }
        public bool UserExist(string _UserName)
        {
            User U = new User { UserName= _UserName };
            U = (User)_userLogic.ReadbyName(U).Result;
            if (U != null)
            {
                return true;
            }
            return false;
        }
    }
}
