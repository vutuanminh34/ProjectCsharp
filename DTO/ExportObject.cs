using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExportObject
    {
        private string export_id;
        private string export_date;
        private string export_staff_id;
        private string export_customer_id;

        public ExportObject()
        {

        }

        public ExportObject(string export_id, string export_date, string export_staff_id, string export_customer_id)
        {
            this.Export_id = export_id;
            this.Export_date = export_date;
            this.Export_staff_id = export_staff_id;
            this.Export_customer_id = export_customer_id;
        }

        public string Export_id { get => export_id; set => export_id = value; }
        public string Export_date { get => export_date; set => export_date = value; }
        public string Export_staff_id { get => export_staff_id; set => export_staff_id = value; }
        public string Export_customer_id { get => export_customer_id; set => export_customer_id = value; }
    }
}
