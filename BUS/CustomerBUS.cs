using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class CustomerBUS
    {
        Data da = new Data();
        CustomerObject C = new CustomerObject();

        public DataTable showKH()
        {
            string sql = "select * from tblcustomer8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertKhachHang(string makh, string tenkh, string nskh, string gtkh, string socmtkh, string dckh, string sdtkh)
        {
            string sql = "insert into tblcustomer8 values(N'" + makh + "',N'" + tenkh + "',N'" + nskh + "',N'" + gtkh + "',N'" + socmtkh + "',N'" + dckh + "',N'" + sdtkh + "')";
            da.ExcuteNonQuery(sql);
        }

        public void UpdateKhachHang(string makh, string tenkh, string nskh, string gtkh, string socmtkh, string dckh, string sdtkh)
        {
            string sql = "update tblcustomer8 set customer_name=N'" + tenkh + "', customer_birth=N'" + nskh + "', customer_gender=N'" + gtkh + "', customer_id_card=N'" + socmtkh + "', customer_address=N'" + dckh + "', customer_phone='" + sdtkh + "' where customer_id=N'" + makh + "'";
            da.ExcuteNonQuery(sql);
        }

        public void DeleteKhacHang(string makh)
        {
            string sql = "delete tblcustomer8 where customer_id=N'" + makh + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchKhachHang(string dk)
        {
            string sql = "select * from tblcustomer8 where customer_id = N'" + dk + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
