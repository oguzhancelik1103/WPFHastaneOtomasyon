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
    /// DoktorBilgiler.xaml etkileşim mantığı
    /// </summary>
    public partial class DoktorBilgiler : Window
    {
        public DoktorBilgiler(string doktorEmail)
        {
            InitializeComponent();
            this.doktorEmail = doktorEmail;
            LoadDoktorInfo(doktorEmail);
        }

        public string doktorEmail;
        private HastaneOtomasyonuEntities dbcontext = new HastaneOtomasyonuEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoktorHastaBilgileri doktorhasta = new DoktorHastaBilgileri(doktorEmail);
            doktorhasta.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdateDoktorInfo();
        }

        private void LoadDoktorInfo(string doktorEmail)
        {
            try
            {
                var doktor = dbcontext.Doktor.FirstOrDefault(d => d.Email == doktorEmail);
                if (doktor != null)
                {
                    doktoremail.Text = doktor.Email;
                    doktorad.Text = doktor.Ad;
                    doktorsoyad.Text = doktor.Soyad;
                    doktoruzmanlik.Text = doktor.Uzmanlik;
                }
                else
                {
                    MessageBox.Show("Doktor bilgileri yüklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

        private void UpdateDoktorInfo()
        {
            try
            {
                var doktor = dbcontext.Doktor.FirstOrDefault(d => d.Email == doktorEmail);
                if (doktor != null)
                {
                    doktor.Email = doktoremail.Text; 
                    doktor.Ad = doktorad.Text;
                    doktor.Soyad = doktorsoyad.Text;
                    doktor.Uzmanlik = doktoruzmanlik.Text;

                    dbcontext.SaveChanges();  // Değişiklikleri veritabanına kaydet
                    MessageBox.Show("Doktor bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenecek doktor bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor bilgileri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
