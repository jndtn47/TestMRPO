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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AuthorizationС authorization = new AuthorizationС();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (authorization.SearchForUsers(tbLogin.Text, tbPassword.Text))
                lblResultAuthorization.Content = authorization.getName;
            else
                lblResultAuthorization.Content = "Пользователь не найден \nПроверьте логин или пароль ";
            //Login login = new Login();
            //login.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }
    }
}
