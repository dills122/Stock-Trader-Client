using NewStockClient.Global_Functions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewStockClient
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        TcpClient clientConn;
        int UserID = 0;

        public Client(TcpClient client, int UserID)
        {
            clientConn = client;
            this.UserID = UserID;
            InitializeComponent();
            BindComboBox(BuyCB);
            BindComboBox(SellCB);
        }

        public void BindComboBox(ComboBox ComboBx)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString()))
            {
                conn.Open();
                string sql = "SELECT StockID, Stock_Text FROM STOCK_LIBRARY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Stock");
                ComboBx.ItemsSource = ds.Tables["Stock"].DefaultView;
                ComboBx.DisplayMemberPath = ds.Tables["Stock"].Columns["Stock_Text"].ToString();
                ComboBx.SelectedValuePath = ds.Tables["Stock"].Columns["StockID"].ToString();
                ComboBx.SelectedIndex = 0;

                //Figure way out to have default select statement in the ddl
            }

        }

        private void Sellbtn_Click(object sender, RoutedEventArgs e)
        {
            TraderEngine.BuyStock(UserID, (int)SellCB.SelectedValue, Convert.ToInt32(SellAmt.Text));
        }

        private void Buybtn_Click(object sender, RoutedEventArgs e)
        {
            TraderEngine.BuyStock(UserID, (int)BuyCB.SelectedValue, Convert.ToInt32(BuyAmt.Text));
        }
    }
}
