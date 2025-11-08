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

namespace Morozova_ISP_231_Lab14_HomeWork
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextName.Text == "student" && Password.Password.ToString() == "pass123")
            {
                MessageBox.Show("Добро пожаловать, student!");
                TextName.Clear();
                Password.Clear();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
