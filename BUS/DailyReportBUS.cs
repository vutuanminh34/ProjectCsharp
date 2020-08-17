using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class DailyReportBUS
    {
        public static List<DailyReportObject> getInfos(DailyReportObject dobj)
        {
            DBDataContext data = new DBDataContext();
            List<DailyReportObject> lst = null;
            lst = (from k in data.tblexportdetail8s
                   join p in data.tblexport8s on k.export_detail_export_id equals p.export_id
                   join l in data.tblproduct8s on k.export_detail_product_id equals l.product_id
                   where p.export_date == dobj.Export_date
                   select new DailyReportObject
                   {
                       Product_name = l.product_name,
                       Export_amount = k.export_amount,
                       Product_exprice = l.product_exprice,
                   }).ToList();
            return lst;
        }
    }
}
