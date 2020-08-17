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
    public class StaffBUS
    {
        Data da = new Data();
        StaffObject S = new StaffObject();

        public DataTable ShowNhanVien()
        {
            string sql = "select * from tblstaff8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        
        public DataTable ShowTrinhDo()
        {
            string sql = "select * from tbldegree8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertNhanvien(string mnv, string tenv, string ns, string gt, string socmt, string dc, string sdt, string matd)
        {
            string sql = "insert into tblstaff8 values(N'"+mnv+"',N'"+tenv+ "',N'"+ns+ "',N'"+gt+ "',N'"+socmt+ "',N'"+dc+ "',N'"+sdt+ "',N'"+matd+"')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateNhanvien(string mnv, string tenv, string ns, string gt, string socmt, string dc, string sdt, string matd)
        {
            string sql = "update tblstaff8 set staff_name=N'" + tenv + "',staff_birth=N'" + ns + "',staff_gender=N'" + gt + "',staff_id_number=N'" + socmt + "',staff_address=N'" + dc + "',staff_phone=N'" + sdt + "',staff_degree_id=N'" + matd + "' where staff_id=N'" + mnv + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteNhanvien(string mnv)
        {
            string sql = "delete tblstaff8 where staff_id=N'" + mnv + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchNhanvien(string dk)
        {
            string sql = "select * from tblstaff8 where staff_id = N'"+dk+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
