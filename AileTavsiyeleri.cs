using AileAnilari.Model;
using AileAnilari.UserControls;
using Microsoft.EntityFrameworkCore;
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
    public partial class AileTavsiyeleri : Form
    {
        private int kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public AileTavsiyeleri()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void btnTavsiyeEkle_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Yeni bir Tavsiyeler nesnesi oluşturur ve formdan gelen verilerle doldurur
            Tavsiyeler tavsiyeler = new Tavsiyeler
            {
                KullaniciID = kullaniciID,
                Baslik = txtTavsiyeBaslik.Text,
                Icerik = txtTavsiyeIcerik.Text,
                Tarih = DateTime.Now
            };
            // Yeni tavsiyeyi veritabanına ekler
            context.Tavsiyeler.Add(tavsiyeler);
            // Değişiklikleri veritabanına kaydeder ve sonucu alır
            int sonuc = context.SaveChanges();
            // Ekleme sonucuna göre mesaj gösterir
            MessageBox.Show($"{(sonuc > 0 ? "Tavsiye Ekleme Başarılı" : "Tavsiye Ekleme Başarısız")}");
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

        private void AileTavsiyeleri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde tavsiyeleri getirir
            TavsiyeleriGetir();
        }

        private void TavsiyeleriGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Tüm tavsiyeleri veritabanından çeker
            var Tavsiyeler = context.Tavsiyeler.ToList();

            // Her tavsiye için bir kart oluşturur ve FlowLayoutPanel'e ekler
            foreach (var tavsiye in Tavsiyeler)
            {
                TavsiyelerKart tavsiyeKart = new TavsiyelerKart();
                tavsiyeKart.Baslik = tavsiye.Baslik;
                tavsiyeKart.Icerik = tavsiye.Icerik;
                tavsiyeKart.EkleyenID = tavsiye.KullaniciID;
                tavsiyeKart.Tarih = tavsiye.Tarih.ToString();
                flp_tavsiyeler.Controls.Add(tavsiyeKart);
            }
        }
    }
}