using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserObject
    {
        private int user_id;
        private string user_name;
        private string user_pass;
        private string user_permission;

        public UserObject()
        {

        }

        public UserObject(int user_id, string user_name, string user_pass, string user_permission)
        {
            this.User_id = user_id;
            this.User_name = user_name;
            this.User_pass = user_pass;
            this.User_permission = user_permission;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string User_pass { get => user_pass; set => user_pass = value; }
        public string User_permission { get => user_permission; set => user_permission = value; }
    }
}
