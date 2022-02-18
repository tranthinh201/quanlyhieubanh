using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Quanlyhieubanh
{
    public class ketnoi
    {
        private string con_str = "";
        private SqlConnection conn = null;

        public ketnoi()
        {
            con_str = @"Data Source=DESKTOP-U9JPINT;Initial Catalog=QuanLyTiemBanh;Integrated Security=True";
            conn = new SqlConnection(con_str);
        }

        public bool thucthi(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet laydulieu(string sql, string tables_name)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(sql, con_str);
                da.Fill(ds, tables_name);
            }
            catch
            {
            }
            return ds;

        }

    }
}
