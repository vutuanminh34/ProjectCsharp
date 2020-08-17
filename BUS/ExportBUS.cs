using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ExportBUS
    {
        public static List<ExportObject> getExports()
        {
            DBDataContext data = new DBDataContext();
            List<ExportObject> lst = null;
            lst = (from export in data.tblexport8s
                   select new ExportObject
                   {
                       Export_id = export.export_id,
                       Export_date = export.export_date.ToString(),
                       Export_staff_id = export.export_staff_id,
                       Export_customer_id = export.export_customer_id
                   }).ToList();
            return lst;
        }

        public static bool createExport(ExportObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                tblexport8 export = new tblexport8();
                export.export_id = similar.Export_id;
                export.export_date = DateTime.Parse(similar.Export_date);
                export.export_staff_id = similar.Export_staff_id;
                export.export_customer_id = similar.Export_customer_id;
                data.tblexport8s.InsertOnSubmit(export);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool updateExport(ExportObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var export = data.tblexport8s.Single(pr => pr.export_id == similar.Export_id);
                export.export_date = DateTime.Parse(similar.Export_date);
                export.export_staff_id = similar.Export_staff_id;
                export.export_customer_id = similar.Export_customer_id;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool deleteExport(ExportObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                var delete = from export in data.tblexport8s
                             where export.export_id == similar.Export_id
                             select export;
                foreach (var i in delete)
                {
                    data.tblexport8s.DeleteOnSubmit(i);
                    data.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ExportObject> searchExport(String conds)
        {
            DBDataContext data = new DBDataContext();
            List<ExportObject> lst = null;
            lst = (from export in data.tblexport8s
                   where export.export_id.Contains(conds)
                   select new ExportObject
                   {
                       Export_id = export.export_id,
                       Export_date = export.export_date.ToString(),
                       Export_staff_id = export.export_staff_id,
                       Export_customer_id = export.export_customer_id
                   }).ToList();
            return lst;
        }
    }
}
