using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AileAnilari.UserControls;
using AileAnilari.Model;

namespace AileAnilari
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde kategorileri getirir
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            // FlowLayoutPanel'deki mevcut kontrolleri temizler
            flp_kategoriler.Controls.Clear();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Tüm kategorileri veritabanından çeker
            var kategori = context.Kategori.ToList();
            // Her kategori için bir kart oluşturur
            foreach (var kategoriList in kategori)
            {
                KategoriKart kategoriler = new KategoriKart();
                kategoriler.Kategori = kategoriList.KategoriAdi;
                // Kategori kartını FlowLayoutPanel'e ekler
                flp_kategoriler.Controls.Add(kategoriler);
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Yeni bir Kategori nesnesi oluşturur ve adını formdan alır
            Kategori kategori = new Kategori()
            {
                KategoriAdi = txt_kategoriAdi.Text
            };

            // Yeni kategoriyi veritabanına ekler
            context.Kategori.Add(kategori);
            // Değişiklikleri veritabanına kaydeder ve sonucu alır
            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                // Ekleme başarılıysa mesaj gösterir ve kategorileri yeniler
                MessageBox.Show("Kategori Ekleme Başarılı");
                KategorileriGetir();
            }
            else
            {
                // Ekleme başarısızsa hata mesajı gösterir
                MessageBox.Show("Kategori Ekleme Başarısız");
            }
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Arama metnine göre kategorileri filtreler
            var kategoriSonuc = context.Kategori.Where(k => k.KategoriAdi.Contains(txt_arama.Text)).ToList();

            // FlowLayoutPanel'deki her kontrolü kontrol eder
            foreach (Control control in flp_kategoriler.Controls)
            {
                if (control is KategoriKart kc)
                {
                    // Kategori kartının adını alır
                    string kategoriAdi = kc.Kategori;
                    // Kartın görünürlüğünü, aranan metne uygunluğuna göre ayarlar
                    kc.Visible = kategoriSonuc.Any(k => k.KategoriAdi == kategoriAdi);
                }
            }
        }
    }
}