using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewStockClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient client;

        public MainWindow()
        {
            InitializeComponent();

            //Attempts connection until it is established
            //Or 30 attempts
            for(int i = 0; i < 30; i++)
            {
                try
                {
                    client = Network.ConnectTCP();
                    Errorlb.Content = "Succcesful Connection";
                    Errorlb.Visibility = Visibility.Visible;
                    Submitbtn.IsEnabled = true;
                    break;
                }
                catch (Exception ex)
                {
                    
                    Debug.Write(ex.ToString());
                    Errorlb.Content = "Failed Connection Retrying..";
                    Errorlb.Visibility = Visibility.Visible;
                    Submitbtn.IsEnabled = false;
                }
            }
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            //Checks the Users credentials 
            int rtnVal = Global_Functions.sql.CheckLogin(Global_Functions.Encryption.HashPassword(Passwordtxt.Password), Usernametxt.Text);
            if (rtnVal > 0)
            {
                //Opens up the Client window
                Client clnt = new Client(client, rtnVal);
                //Hides the Login Panel
                this.Visibility = Visibility.Hidden;
                clnt.ShowDialog();
                Close();
            }
        }

        private void Newuserbtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string BtnText = (string)btn.Content;

            if (BtnText.Contains("New"))
            {
                UserOp Usr = new UserOp(1);
                this.Visibility = Visibility.Hidden;
                Usr.ShowDialog();
                Close();
            }
            else if (BtnText == "Forgot Password")
            {
                UserOp Usr = new UserOp(2);
                this.Visibility = Visibility.Hidden;
                Usr.ShowDialog();
                Close();
            }
        }
    }
}
