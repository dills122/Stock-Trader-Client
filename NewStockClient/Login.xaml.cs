using System;
using System.Collections.Generic;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, RoutedEventArgs e)
        {
            //Checks the Users credentials 
            bool rtnVal = Global_Functions.sql.CheckLogin(Global_Functions.Encryption.HashPassword(Passwordtxt.Password), Usernametxt.Text);
            if (rtnVal == true)
            {
                //Opens up the Client window
                Client clnt = new Client();
                //Hides the Login Panel
                this.Visibility = Visibility.Hidden;
                clnt.ShowDialog();
                Close();
            }
        }

        private void Newuserbtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string str = (string)btn.Content;
        }
    }
}
