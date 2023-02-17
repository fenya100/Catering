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

namespace WpfApp10.QuestPages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.User.Count(x => x.Login == TxbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }
            else
            {
                try 
                {
                    User userObj = new User()
                    {
                        Login = TxbLogin.Text,
                        Password = PsbPassword.Password,
                        IdRole = 1
                    };
                    DbConnect.entObj.User.Add(userObj);
                    DbConnect.entObj.SaveChanges();

                    MessageBox.Show("Пользователь создан!",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                    "Критический сбой работы приложения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                }
              }
        }

        private void BtnReg_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TxbPassword.Text == PsbPassword.Password)
            {
                BtnReg.IsEnabled = true;
                PsbPassword.Background = Brushes.LightBlue;
            }
            else
            {
                BtnReg.IsEnabled = false;
                PsbPassword.BorderBrush = Brushes.Red;
            }
        }
    }
}
