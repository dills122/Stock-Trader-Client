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
        public static int CheckLogin(string HashedPass, string Username)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString()))
            {

                conn.Open();
                string sql = "select Password_Hash, UserID FROM STOCK_USER where Username=@Username";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Username", Username));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["Password_Hash"].ToString() == HashedPass)
                    {
                        return (int)dr["UserID"];
                    }
                }
                dr.Close();
            }
            return 0;
        }
    }
}
