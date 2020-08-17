using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DistributorObject
    {
        private String distributor_id;
        private String distributor_name;
        private String distributor_address;
        private String distributor_phone;
        private String distributor_email;

        public DistributorObject()
        {
        }

        public DistributorObject(string distributor_id, string distributor_name, string distributor_address, string distributor_phone, string distributor_email)
        {
            this.distributor_id = distributor_id;
            this.distributor_name = distributor_name;
            this.distributor_address = distributor_address;
            this.distributor_phone = distributor_phone;
            this.distributor_email = distributor_email;
        }

        public string Distributor_id { get => distributor_id; set => distributor_id = value; }
        public string Distributor_name { get => distributor_name; set => distributor_name = value; }
        public string Distributor_address { get => distributor_address; set => distributor_address = value; }
        public string Distributor_phone { get => distributor_phone; set => distributor_phone = value; }
        public string Distributor_email { get => distributor_email; set => distributor_email = value; }
    }
}
