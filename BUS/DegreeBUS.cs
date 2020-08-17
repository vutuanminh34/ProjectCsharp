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
    public class DegreeBUS
    {
        Data da = new Data();
        DegreeObject D = new DegreeObject();

        public DataTable ShowTrinhDo()
        {
            string sql = "select * from tbldegree8";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertTrinhDo(string mtd, string ttd)
        {
            string sql = "insert tbldegree8 values(N'" + mtd + "',N'" + ttd + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateTrinhdo(string mtd, string ttd)
        {
            string sql = "update tbldegree8 set degree_name = N'" + ttd + "' where degree_id = N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteTrinhDo(string mtd)
        {
            string sql = "delete tbldegree8 where degree_id = N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
