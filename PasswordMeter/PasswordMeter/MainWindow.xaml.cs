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
            username = userNameTextBox.Text;
            password = passwordTextBox.Text;

            username = username.Trim();
            password = password.Trim();

            bool containsUsername = password.Contains(username);

            bool isDigit = false;

            for (int i = 0; i < password.Length - 1; i++)
            {
                char letter;
                string eerstVolgendeLetter = password.Substring(i, i + 1);
                letter = char.Parse(eerstVolgendeLetter);

                isDigit = char.IsDigit(letter);
                if (isDigit == true)
                {
                    break;

                }
                bool contains10Characters = password.Length >= 10;



                if(containsUsername == false && isDigit == true && contains10Characters == true)
                {
                    resultTextBlock.Text = "Wachtwoord OK";
                    resultTextBlock.Foreground = Brushes.Green;
                }
                else
                {
                    resultTextBlock.Text = "Wachtwoord NIET OK";
                    resultTextBlock.Foreground= Brushes.Red;

                }
                
            }
        }
    }
} 