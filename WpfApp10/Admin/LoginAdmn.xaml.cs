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
using WpfApp10.AppServices;

namespace WpfApp10.Admin
{
    /// <summary>
    /// Логика взаимодействия для LoginAdmn.xaml
    /// </summary>
    public partial class LoginAdmn : Page
    {
        public LoginAdmn()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.User.Count(x => x.Login == TxbLogin.Text) > 0)
            {

                if (DbConnect.entObj.User.Count(x => x.Password == PsbPassword.Password) > 0)
                {
                    MessageBox.Show("Привет, " + TxbLogin.Text,
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                    FrameApp.BtnCheck1.Visibility = Visibility.Visible;
                    FrameApp.BtnCheck2.Visibility = Visibility.Visible;
                    FrameApp.BtnCheck3.Visibility = Visibility.Visible;
                    FrameApp.BtnCheck4.Visibility = Visibility.Visible;

                    
                    return;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                    return;
                }
            }
        }
    }
}
