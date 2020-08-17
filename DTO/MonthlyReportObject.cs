using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonthlyReportObject
    {
        private string product_id;
        private string product_name;
        private double? product_imamount;
        private double? product_examount;
        public MonthlyReportObject()
        {
        }

        public MonthlyReportObject(string product_id, string product_name, double? product_imamount, double? product_examount)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.product_imamount = product_imamount;
            this.product_examount = product_examount;
        }

        public string Product_name { get => product_name; set => product_name = value; }
        public string Product_id { get => product_id; set => product_id = value; }
        public double? Product_imamount { get => product_imamount; set => product_imamount = value; }
        public double? Product_examount { get => product_examount; set => product_examount = value; }
    }
}
