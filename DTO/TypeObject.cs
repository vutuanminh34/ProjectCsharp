using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TypeObject
    {
        private String type_id;
        private string type_name;

        public TypeObject()
        {

        }

        public TypeObject(string type_id, string type_name)
        {
            this.Type_id = type_id;
            this.Type_name = type_name;
        }

        public string Type_id { get => type_id; set => type_id = value; }
        public string Type_name { get => type_name; set => type_name = value; }
    }
}
