using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnCaNhan
{
    class ClassChung
    {
        SqlConnection conn;
        public ClassChung() 
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ktvie\source\repos\DoAnCaNhan\DoAnCaNhan\CFDT.mdf;Integrated Security=True";
            conn = new SqlConnection(chuoiketnoi);
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            return ketqua;
        }
        public DataTable Taidulieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public object Laygiatri(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object ketqua = comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
