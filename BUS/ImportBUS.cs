using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class ImportBUS
    {
        Data da = new Data();
        ImportObject I = new ImportObject();
        ImportdetailObject ID = new ImportdetailObject();
        ProductObject P = new ProductObject();

        public DataTable showNCC()
        {
            string sql = "select * from tbldistributor8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable showSP()
        {
            string sql = "select * from tblproduct8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable showNV()
        {
            string sql = "select * from tblstaff8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable showCTPN(string mapn)
        {
            string sql = "select * from tblimportdetail8 where import_detail_import_id = N'" + mapn+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public DataTable showPN(string mapn)
        {
            string sql = "select * from tblimport8 where import_id = N'" + mapn + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertPN(string mpn, string ngaypn, string manvpn, string manccpn)
        {
            string sql = "insert tblimport8 values(N'" + mpn + "',N'" + ngaypn + "',N'" + manvpn + "',N'" + manccpn + "')";
            da.ExcuteNonQuery(sql);
        }

        public void InvertCTPN(string mpn, string msp, int sln)
        {
            string sql = "insert tblimportdetail8 values(N'" + mpn + "',N'" + msp + "',N'" + sln + "')";
            da.ExcuteNonQuery(sql);
        }

        public void UpdateSLSP(string msp,int sln)
        {
            string sql = "update tblproduct8 set product_amount = product_amount + N'" + sln + "' where product_id = N'" + msp + "'";
            da.ExcuteNonQuery(sql);
        }

        public bool check2(string mapn)
        {
            string sql = "select import_id from tblimport8 where import_id = N'" + mapn + "'";
            if(da.check(sql) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
