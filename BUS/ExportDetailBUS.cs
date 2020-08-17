using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ExportDetailBUS
    {
        public static List<ExportDetailObject> getExportDetails()
        {
            DBDataContext data = new DBDataContext();
            List<ExportDetailObject> lst = null;
            lst = (from exportDetail in data.tblexportdetail8s
                   select new ExportDetailObject
                   {
                       Export_detail_export_id = exportDetail.export_detail_export_id,
                       Export_detail_product_id = exportDetail.export_detail_product_id,
                       Export_detail_amount = exportDetail.export_amount
                   }).ToList();
            return lst;
        }

        public static bool createExportDetail(ExportDetailObject similar)
        {
            DBDataContext data = new DBDataContext();
            try
            {
                tblexportdetail8 exportDetail = new tblexportdetail8();
                exportDetail.export_detail_export_id = similar.Export_detail_export_id;
                exportDetail.export_detail_product_id = similar.Export_detail_product_id;
                exportDetail.export_amount = similar.Export_detail_amount;
                data.tblexportdetail8s.InsertOnSubmit(exportDetail);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public static List<ExportDetailObject> searchExportDetail(String conds)
        {
            DBDataContext data = new DBDataContext();
            List<ExportDetailObject> lst = null;
            lst = (from exportDetail in data.tblexportdetail8s
                   where (exportDetail.export_detail_export_id == conds)
                   select new ExportDetailObject
                   {
                       Export_detail_export_id = exportDetail.export_detail_export_id,
                       Export_detail_product_id = exportDetail.export_detail_product_id,
                       Export_detail_amount = exportDetail.export_amount,
                       Product_id = exportDetail.tblproduct8.product_id,
                       Product_name = exportDetail.tblproduct8.product_name,
                       Product_brand = exportDetail.tblproduct8.product_brand,
                       Product_exprice = exportDetail.tblproduct8.product_exprice
                   }).ToList();
            return lst;
        }

    }
}
