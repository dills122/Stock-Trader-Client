using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStockClient.Global_Functions
{
    static class sql
    {
        public static bool CheckLogin(string HashedPass, string Username)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString()))
            {

                conn.Open();
                string sql = "select Password_Hash FROM STOCK_USER where Username=@Username";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Username", Username));

                string DBHash = (string)cmd.ExecuteScalar();

                if (DBHash == HashedPass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
