using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Net.NetworkInformation;

namespace BUS
{
    public class MonthlyReportBUS
    {
        public static List<MonthlyReportObject> getImamount(DateTime date)
        {
            DateTime dtBef = new DateTime(2015,1,1);
            DateTime dtAft = new DateTime(Convert.ToDateTime(date).Year,Convert.ToDateTime(date).Month,30);
            DBDataContext data = new DBDataContext();
            List<MonthlyReportObject> lst = null;
            lst = (from ed in data.tblimportdetail8s
                   join e in data.tblimport8s on ed.import_detail_import_id equals e.import_id
                   join ep in data.tblproduct8s on ed.import_detail_product_id equals ep.product_id
                   where e.import_date <= dtAft && e.import_date >= dtBef
                   group new { ed, e, ep} by new { ed.import_detail_product_id } into pg
                   let id = pg.FirstOrDefault()
                   let baseid = id.ed.import_detail_product_id
                   let basename = id.ep.product_name
                   let amount = pg.Sum(m => m.ed.import_amount)
                   select new MonthlyReportObject
                   {
                       Product_id = baseid,
                       Product_name = basename,
                       Product_imamount = amount
                   }).ToList();
            return lst;
        }

        public static List<MonthlyReportObject> getExamount(DateTime date)
        {
            DateTime dtBef = new DateTime(2015, 1, 1);
            DateTime dtAft = new DateTime(Convert.ToDateTime(date).Year, Convert.ToDateTime(date).Month, 30);
            DBDataContext data = new DBDataContext();
            List<MonthlyReportObject> lst = null;
            lst = (from ed in data.tblexportdetail8s
                   join e in data.tblexport8s on ed.export_detail_export_id equals e.export_id
                   join ep in data.tblproduct8s on ed.export_detail_product_id equals ep.product_id
                   where e.export_date <= dtAft && e.export_date >= dtBef
                   group new { ed, e ,ep} by new { ed.export_detail_product_id } into pg
                   let id = pg.FirstOrDefault()
                   let baseid = id.ed.export_detail_product_id
                   let basename = id.ep.product_name
                   let amount = pg.Sum(m => m.ed.export_amount)
                   select new MonthlyReportObject
                   {  
                       Product_id = baseid,
                       Product_name = basename,
                       Product_examount = amount
                   }).ToList();
            return lst;
        }
    }
}
