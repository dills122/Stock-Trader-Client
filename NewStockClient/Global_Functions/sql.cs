using System;
using System.Collections;
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

        public static int RetrievePassword(string QuereyText, char QuereyType)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString()))
            {

                //conn.Open();
                //string sql = "select Password_Hash, UserID FROM STOCK_USER where Username=@Username";

                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.Add(new SqlParameter("@Username", Username));

                //SqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{

                //    if (dr["Password_Hash"].ToString() == HashedPass)
                //    {
                //        return (int)dr["UserID"];
                //    }
                //}
                dr.Close();
            }
            return 0;
        }

        public static ArrayList TransactionHistory(int UserID)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString()))
            {
                ArrayList Transactions = new ArrayList();
                conn.Open();
                string sql = "SELECT TOP 10 SL.Stock_Abrv, UTL.Method, UTL.Date, UTL.Cost, UTL.Amount FROM USER_TRANS_LOG AS UTL INNER JOIN STOCK_LIBRARY AS SL ON SL.StockID = UTL.StockID WHERE UTL.UserID = @UserID ORDER BY UTL.Date";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    
                    while(dr.Read())
                    {
                        Transactions.Add(new Transaction((string)dr["Stock_Abrv"], (bool)dr["Method"], (string)dr["Date"], (float)dr["Cost"], (int)dr["Amount"]));
                    }
                    dr.Close();
                }
                conn.Close();
                conn.Dispose();

                return Transactions;
            }

        }

        public class Transaction
        {
            public Transaction(string StockAbr, bool Method, string TDate, float Cost, int Amt )
            {
                this.Name = StockAbr;
                this.Method = Method;
                this.Date = TDate;
                this.Cost = Cost;
                this.Amount = Amt;
            }

            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private bool method;

            public bool Method
            {
                get { return method; }
                set { method = value; }
            }
            private string date;

            public string Date
            {
                get { return date; }
                set { date = value; }
            }
            private float cost;

            public float Cost
            {
                get { return cost; }
                set { cost = value; }
            }

            private int amount;

            public int Amount
            {
                get { return amount; }
                set { amount = value; }
            }
        }
    }
}
