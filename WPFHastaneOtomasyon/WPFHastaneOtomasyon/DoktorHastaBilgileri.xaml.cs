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
using static MaterialDesignThemes.Wpf.Theme;

namespace WPFHastaneOtomasyon
{
    /// <summary>
    /// DoktorHastaBilgileri.xaml etkileşim mantığı
    /// </summary>
    public partial class DoktorHastaBilgileri : Window
    {
        public DoktorHastaBilgileri(string doktorEmail)
        {
            InitializeComponent();
            this.doktorEmail = doktorEmail;
            LoadData();
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
            DoktorBilgiler doktor = new DoktorBilgiler(doktorEmail);
            doktor.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                var yeniHasta = new Hasta
                {
                    Email = hastaemail.Text,
                    Sifre = hastasifre.Text,
                    Ad = hastaad.Text,
                    Soyad = hastasoyad.Text,
                    Adres = hastaadres.Text,
                    DogumTarihi = hastadogum.SelectedDate
                };

                dbcontext.Hasta.Add(yeniHasta);  
                dbcontext.SaveChanges(); 

                MessageBox.Show("Hasta başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta eklenirken bir hata oluştu: " + ex.Message);
            }
            LoadData();
        }

        private void LoadData()
        {
            dbcontext.Hasta.Load(); 
            DataView.ItemsSource = dbcontext.Hasta.Local; 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                Hasta selectedHasta = DataView.SelectedItem as Hasta;
                if (selectedHasta != null)
                {
                    selectedHasta.Email = hastaemail.Text;
                    selectedHasta.Sifre = hastasifre.Text;
                    selectedHasta.Ad = hastaad.Text;
                    selectedHasta.Soyad = hastasoyad.Text;
                    selectedHasta.Adres = hastaadres.Text;
                    selectedHasta.DogumTarihi = hastadogum.SelectedDate;

                    dbcontext.SaveChanges();  
                    MessageBox.Show("Hasta bilgileri başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncellenecek hasta bulunamadı. Lütfen doğru e-posta adresini giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta bilgileri güncellenirken bir hata oluştu: " + ex.Message);
            }
            LoadData();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Hasta selectedHasta = DataView.SelectedItem as Hasta;
            if (selectedHasta != null)
            {
                dbcontext.Hasta.Remove(selectedHasta);

                dbcontext.SaveChanges();

                MessageBox.Show("Hasta başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek hastayı seçin.");
            }
            LoadData();
        }

        private void DataView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataView.SelectedItem != null)
            {
                Hasta selectedHasta = DataView.SelectedItem as Hasta;
                if (selectedHasta != null)
                {
                    hastaemail.Text = selectedHasta.Email;
                    hastasifre.Text = selectedHasta.Sifre;
                    hastaad.Text = selectedHasta.Ad;
                    hastasoyad.Text = selectedHasta.Soyad;
                    hastaadres.Text = selectedHasta.Adres;
                    hastadogum.SelectedDate = selectedHasta.DogumTarihi;
                }
            }
            LoadData();
        }
    }
}
