using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Hotel
{
    public class Functions
    {
        static SqlConnection conn = new SqlConnection();
        public static void getConn()
        {
            conn.ConnectionString = "Server=LTFA_LT\\SQLSERVER_151222;Database=HotelDB;User Id=sa;Password=01312101220;";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public static void closeConn()
        {
            conn.Close();
        }

        public static DataTable getData(string sql)
        {
            getConn();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = new SqlCommand(sql, conn);
            adap.Fill(dt);
            closeConn();
            return dt;
        }
    }
}
