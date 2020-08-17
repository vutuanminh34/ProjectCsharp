using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DailyReportObject
    {
        private String product_name;
        private DateTime export_date;
        private int? export_amount;
        private double? product_exprice;
        public DailyReportObject()
        {
        }
        public DailyReportObject(string product_name, DateTime export_date, int? export_amount, double? product_exprice)
        {
            this.product_name = product_name;
            this.export_date = export_date;
            this.export_amount = export_amount;
            this.product_exprice = product_exprice;
        }
        public string Product_name { get => product_name; set => product_name = value; }
        public DateTime Export_date { get => export_date; set => export_date = value; }
        public int? Export_amount { get => export_amount; set => export_amount = value; }
        public double? Product_exprice { get => product_exprice; set => product_exprice = value; }
    }
}
