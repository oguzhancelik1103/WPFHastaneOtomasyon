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
    /// HastaKayit.xaml etkileşim mantığı
    /// </summary>
    public partial class HastaKayit : Window
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        private HastaneOtomasyonuEntities dbcontext = new HastaneOtomasyonuEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HastaLogin hastalogin = new HastaLogin();
            hastalogin.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Hasta yenihasta = new Hasta
                {
                    Email = hastaemail.Text,
                    Sifre = hastasifre.Text,
                    Ad = hastaad.Text,
                    Soyad = hastasoyad.Text,
                    DogumTarihi = DateTime.Parse(hastadogum.Text),
                    Adres = hastaadres.Text
                };

                dbcontext.Hasta.Add(yenihasta);
                dbcontext.SaveChanges();
                MessageBox.Show("Kayıt başarılı!");
                HastaLogin hastaLogin = new HastaLogin();
                hastaLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message);
            }
        }
    }
}
