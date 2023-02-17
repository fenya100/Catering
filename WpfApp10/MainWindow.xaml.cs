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

using System.Windows.Threading;
using WpfApp10.Admin;
using WpfApp10.AppServices;
using WpfApp10.Pages;
using WpfApp10.QuestPages;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameApp.BtnCheck1 = Btn1;
            FrameApp.BtnCheck2 = Btn2;
            FrameApp.BtnCheck3 = Btn3;
            FrameApp.BtnCheck4 = Btn4;

            FrameApp.frmObj = FrmMain;

            DbConnect.entObj = new CateringEntities();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMenu());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            FrameApp.frmObj.Navigate(new LoginAdmn());
        }

        private void BtnRegistr_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Registration());
        }

        private void Salat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
