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
    /// HastaBilgiler.xaml etkileşim mantığı
    /// </summary>
    public partial class HastaBilgiler : Window
    {
        public HastaBilgiler(string hastaEmail)
        {
            InitializeComponent();
            this.hastaEmail = hastaEmail;
            LoadHastaInfo(hastaEmail);
        }

        private string hastaEmail;
        private HastaneOtomasyonuEntities dbcontext = new HastaneOtomasyonuEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HastaBilgiler hasta = new HastaBilgiler(hastaEmail);
            hasta.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdateHastaInfo();
        }

        private void LoadHastaInfo(string hastaEmail)
        {
            try
            {
                var hasta = dbcontext.Hasta.FirstOrDefault(d => d.Email == hastaEmail);
                if (hasta != null)
                {
                    hastaemail.Text = hasta.Email;
                    hastaad.Text = hasta.Ad;
                    hastasoyad.Text = hasta.Soyad;
                    hastaadres.Text = hasta.Adres;
                    hastadogum.SelectedDate = hasta.DogumTarihi;
                }
                else
                {
                    MessageBox.Show("Hasta bilgileri yüklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

        private void UpdateHastaInfo()
        {
            try
            {
                var hasta = dbcontext.Hasta.FirstOrDefault(h => h.Email == hastaEmail);
                if (hasta != null)
                {
                    // Kullanıcı arayüzündeki kontrollerden bilgi alınıp, hasta nesnesine atanıyor
                    hasta.Email = hastaemail.Text;  // Email değiştirilebilir ise, aksi takdirde bu satırı kaldırın.
                    hasta.Ad = hastaad.Text;
                    hasta.Soyad = hastasoyad.Text;
                    hasta.Adres = hastaadres.Text;
                    hasta.DogumTarihi = hastadogum.SelectedDate;

                    dbcontext.SaveChanges();  // Değişiklikleri veritabanına kaydet
                    MessageBox.Show("Hasta bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenecek hasta bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta bilgileri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
