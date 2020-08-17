using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BUS.Utilities;

namespace BUS
{
    public class UserBUS
    {
        public static List<UserObject> getUsers()
        {
            DBDataContext data = new DBDataContext();
            List<UserObject> lst = null;
            lst = (from user in data.tbluser8s
                   select new UserObject
                   {
                       User_id = user.user_id,
                       User_name = user.user_name,
                       User_pass = user.user_pass,
                       User_permission = user.user_permission
                   }).ToList();
            return lst;
        }

        public static List<UserObject> getUsers(string userName, string userPass)
        {
            userPass = PasswordMD5.Encrypt(userPass);
            DBDataContext data = new DBDataContext();
            List<UserObject> lst = null;
            lst = (from user in data.tbluser8s 
                   where user.user_name == userName && user.user_pass == userPass
                   select new UserObject
                   {
                       User_id = user.user_id,
                       User_name = user.user_name,
                       User_pass = user.user_pass,
                       User_permission = user.user_permission
                   }).ToList();
            return lst;
        }

        public static bool createUser(UserObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                tbluser8 user = new tbluser8();
                user.user_id = similar.User_id;
                user.user_name = similar.User_name;
                user.user_pass = PasswordMD5.Encrypt(similar.User_pass);
                user.user_permission = similar.User_permission;
                data.tbluser8s.InsertOnSubmit(user);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateUser(UserObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var user = data.tbluser8s.Single(pr => pr.user_id == similar.User_id);
                user.user_name = similar.User_name;
                user.user_pass = similar.User_pass;
                user.user_permission = similar.User_permission;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteUser(UserObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var delete = from user in data.tbluser8s
                             where user.user_id == similar.User_id
                             select user;
                foreach (var i in delete)
                {
                    data.tbluser8s.DeleteOnSubmit(i);
                    data.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<UserObject> searchUser(String conds)
        {
            try
            {
                DBDataContext data = new DBDataContext();
                List<UserObject> lst = null;
                lst = (from user in data.tbluser8s
                       where user.user_id == Int32.Parse(conds)
                       select new UserObject
                       {
                           User_id = user.user_id,
                           User_name = user.user_name,
                           User_pass = user.user_pass,
                           User_permission = user.user_permission
                       }).ToList();
                return lst;
            } catch
            {
                return null;
            }
        }
    }
}
