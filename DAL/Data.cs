using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=.;Initial Catalog=namngu;Integrated Security=True");
        }

        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

        public bool check(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count >= 1)
            {
                return true;//tồn tại
            }
            else
            {
                return false;//chưa tồn tại
            }
        }
    }
}
