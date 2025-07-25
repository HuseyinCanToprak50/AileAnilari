using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileAnilari
{
    public partial class Profilim : Form
    {
        private int kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public Profilim()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void Profilim_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde kullanıcı bilgilerini getirir
            KullaniciBilgileri();
        }

        private void KullaniciBilgileri()
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ID'sine göre veritabanından bulur
            var kullanicilar = context.Kullanicilar.Where(k => k.Id == kullaniciID).FirstOrDefault();
            if (kullanicilar != null)
            {
                // Kullanıcı bilgilerini etiketlere atar
                lbl_adiSoyadi.Text = kullanicilar.AdiSoyadi;
                lbl_Rol.Text = kullanicilar.Rol;
                lbl_mail.Text = kullanicilar.Mail;
                lbl_dogumTarihi.Text = kullanicilar.DogumTarihi.ToString();
                lbl_telefon.Text = kullanicilar.Telefon;
                lbl_adres.Text = kullanicilar.Adres;
                lbl_meslek.Text = kullanicilar.Meslek;
                lbl_cinsiyet.Text = kullanicilar.Cinsiyet;
                lbl_kayıtTarih.Text = kullanicilar.KayitTarihi.ToString();

                // Kullanıcı bilgilerini güncellemek için input alanlarını doldurur
                txt_AdiSoyadi.Text = kullanicilar.AdiSoyadi;
                txt_Rol.Text = kullanicilar.Rol;
                txt_Mail.Text = kullanicilar.Mail;
                date_dogumTarihi.Value = kullanicilar.DogumTarihi ?? DateTime.Now;
                txt_telefon.Text = kullanicilar.Telefon;
                txt_adres.Text = kullanicilar.Adres;
                txt_Meslek.Text = kullanicilar.Meslek;
                combo_Cinsiyet.Text = kullanicilar.Cinsiyet;
            }
        }

        private void AktifKullaniciID()
        {
            // Açık formlar arasında AnaPanel formunu bulur
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is AnaPanel)
                {
                    // AnaPanel formunu bulup kullanıcı ID'sini etiketten alır
                    AnaPanel panel = (AnaPanel)frm;
                    kullaniciID = int.Parse(panel.lbl_kullaniciID.Text);
                    return;
                }
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ID'sine göre veritabanından bulur
            var kullanici = context.Kullanicilar.Where(k => k.Id == kullaniciID).FirstOrDefault();
            if (kullanici != null)
            {
                // Kullanıcı bilgilerini formdan gelen verilerle günceller
                kullanici.AdiSoyadi = txt_AdiSoyadi.Text;
                kullanici.Rol = txt_Rol.Text;
                kullanici.Mail = txt_Mail.Text;
                kullanici.DogumTarihi = date_dogumTarihi.Value;
                kullanici.Telefon = txt_telefon.Text;
                kullanici.Adres = txt_adres.Text;
                kullanici.Meslek = txt_Meslek.Text;
                kullanici.Cinsiyet = combo_Cinsiyet.Text;

                // Değişiklikleri veritabanına kaydeder ve sonucu alır
                int sonuc = context.SaveChanges();
                // Güncelleme sonucuna göre mesaj gösterir
                MessageBox.Show($"{(sonuc > 0 ? "Güncelleme Başarılı" : "Güncelleme başarısız")}");
            }
        }
    }
}