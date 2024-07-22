using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace WPFHastaneOtomasyon
{
    /// <summary>
    /// DoktorLogin.xaml etkileşim mantığı
    /// </summary>
    public partial class DoktorLogin : Window
    {
        public DoktorLogin()
        {
            InitializeComponent();
        }

        private HastaneOtomasyonuEntities dbcontext = new HastaneOtomasyonuEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var doktor = dbcontext.Doktor.FirstOrDefault(d => d.Email == doktoremail.Text && d.Sifre == doktorsifre.Password);

            if (doktor != null)
            {
                DoktorBilgiler doktorBilgiler = new DoktorBilgiler(doktor.Email);
                doktorBilgiler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-posta veya şifre hatalı. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
