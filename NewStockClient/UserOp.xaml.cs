using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;

namespace NewStockClient
{
    /// <summary>
    /// Interaction logic for UserOp.xaml
    /// </summary>
    public partial class UserOp : Window
    {
        public UserOp(int PanelCode)
        {
            InitializeComponent();

            if (PanelCode == 1) //New User
            {
                NewUsergrd.Visibility = Visibility.Visible;
                Forgotgrd.Visibility = Visibility.Hidden;
            }
            else if (PanelCode == 2) //Forgot Password
            {
                NewUsergrd.Visibility = Visibility.Hidden;
                Forgotgrd.Visibility = Visibility.Visible;
            }
        }

        private void Usernametxt_LostFocus(object sender, RoutedEventArgs e)
        {
            Regex reg = new Regex(" ^ (?=.*[A - Za - z])(?=.*\\d)[A - Za - z\\d]{ 8,}$");
            if (reg.IsMatch(Usernametxt.Text))
            {
                Createbtn.IsEnabled = true;
            }
            else
            {
                Createbtn.IsEnabled = false;
            }
        }

        private void Createbtn_Click(object sender, RoutedEventArgs e)
        {

        }


        private void CPasswordtxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Passwordtxt.Text == CPasswordtxt.Text)
            {
                Passwordtxt.BorderBrush = System.Windows.Media.Brushes.Black;
                CPasswordtxt.BorderBrush = System.Windows.Media.Brushes.Black;
                Regex reg = new Regex(" ^ (?=.*[a - z])(?=.*[A - Z])(?=.*\\d)(?=.*[$@$!% *? &])[A - Za - z\\d$@$!% *? &]{ 8, 10 }");
                if (reg.IsMatch(CPasswordtxt.Text))
                {
                    Passwordtxt.BorderBrush = System.Windows.Media.Brushes.Black;
                    CPasswordtxt.BorderBrush = System.Windows.Media.Brushes.Black;
                }
                else
                {
                    Passwordtxt.BorderBrush = System.Windows.Media.Brushes.Red;
                    CPasswordtxt.BorderBrush = System.Windows.Media.Brushes.Red;
                }
            }
            else
            {
                Passwordtxt.BorderBrush = System.Windows.Media.Brushes.Red;
                CPasswordtxt.BorderBrush = System.Windows.Media.Brushes.Red;
            }
        }

        private void ForgotEmailtxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(ForgotEmailtxt.Text)== false)
            {
                ForgotUsernametxt.Text = "";
            }
        }

        private void ForgotUsernametxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(ForgotUsernametxt.Text) ==false)
            {
                ForgotEmailtxt.Text = "";
            }
        }

        private void ForgotPassbtn_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(Usernametxt.Text) == false)
            {

            }
            else if (String.IsNullOrEmpty(ForgotEmailtxt.Text) == false)
            {

            }
        }
    }
}
