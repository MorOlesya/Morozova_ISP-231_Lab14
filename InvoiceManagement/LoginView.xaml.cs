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

namespace InvoiceManagement
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLoginBtnClicked(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;
            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");
            switch (envPw)
            {
                case null:
                    MessageBox.Show("Перемнная среды не найдена!");
                    break;
                case var pv when envPw == passwordEntered:
                    MessageBox.Show("Введён правильный пароль");
                    break;
                default:
                    MessageBox.Show("Введён неправильный пароль");
                    break;
            }
        }

        public void OnPasswordChanged(object sender, EventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}
