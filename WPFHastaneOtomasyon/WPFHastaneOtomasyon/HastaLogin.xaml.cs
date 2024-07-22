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
using System.Windows.Shapes;

namespace WPFHastaneOtomasyon
{
    /// <summary>
    /// HastaLogin.xaml etkileşim mantığı
    /// </summary>
    public partial class HastaLogin : Window
    {
        public HastaLogin()
        {
            InitializeComponent();
        }

        private HastaneOtomasyonuEntities dbcontext = new HastaneOtomasyonuEntities();

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            HastaKayit hastakayit = new HastaKayit();
            hastakayit.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var hasta = dbcontext.Hasta.FirstOrDefault(h => h.Email == hastaEmail.Text && h.Sifre == hastasifre.Password);

            if(hasta != null)
            {
                HastaBilgiler hastaBilgiler = new HastaBilgiler(hasta.Email);
                hastaBilgiler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-posta veya şifre hatalı. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
