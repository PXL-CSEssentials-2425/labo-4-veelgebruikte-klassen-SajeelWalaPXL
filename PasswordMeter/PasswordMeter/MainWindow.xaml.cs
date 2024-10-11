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

namespace PasswordMeter
{

    public partial class MainWindow : Window
    {
        string username;
        string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private string generatePassword(string username, string password)
        {


            string result = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int randomInt = rnd.Next(0, username.Length);
                string randomString = username.Substring(randomInt, 1);

                sb.Append(randomString.ToLower());
            }
            for (int i = 0; i < 5; i++)
            {
                int randomInt = rnd.Next(0, 10);
                sb.Append(randomInt);
            }
            
            
            
            
            return result;

        }
    }
}