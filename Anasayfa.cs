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
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AileAnilari
{
    public partial class Anasayfa : Form
    {
        private string _kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public Anasayfa(string KullaniciID)
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
            // Parametre olarak gelen kullanıcı ID'sini sınıf değişkenine atar
            this._kullaniciID = KullaniciID;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde anıları ve kullanıcı ismini getirir
            AnilariGetir();
            isimGetir();
        }

        private void AnilariGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıya ait anıları, kategori ve medya bilgileriyle birlikte çeker
            var anilar = context.Anilar.Include(kategori => kategori.Kategori).Include(medya => medya.Medyalar).Where(kullanici => kullanici.EkleyenKullaniciID == int.Parse(_kullaniciID)).ToList();
            // Resim dosyası uzantılarını tanımlar
            string[] resimUzantilari = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            // Varsayılan resim yolunu belirler
            string varsayilanResimYolu = Path.Combine(Application.StartupPath, "Images", "varsayilan.jpg");

            // Veri tabanında KategoriID'lere karşılık gelen kategori adlarını çeker
            var kategoriAd = context.Anilar.Include(k => k.Kategori).ToList();

            foreach (var ani in anilar)
            {
                // Anıyı ekleyen kullanıcının ad ve soyadını bulur
                var yazar = context.Kullanicilar
                    .Where(y => y.Id == ani.EkleyenKullaniciID)
                    .Select(y => y.AdiSoyadi)
                    .FirstOrDefault();

                // Anıya ait medyalar arasından ilk resim dosyasını bulur
                var ilkResim = ani.Medyalar
                    .Where(m => resimUzantilari.Contains(Path.GetExtension(m.DosyaYolu).ToLower()))
                    .FirstOrDefault()?.DosyaYolu;

                // İçeriği 100 karakterden uzunsa 60 karaktere kısaltır ve sonuna "...." ekler
                string ozetIcerik = ani.Icerik.Length > 100 ? ani.Icerik.Substring(0, 60) + "...." : ani.Icerik;

                // Yeni bir anı kartı oluşturur
                AniKart kartlar = new AniKart();
                kartlar.AnıID = ani.AnıID;
                kartlar.Baslik = ani.Baslik;
                kartlar.Tarih = ani.Tarih.ToString();
                kartlar.Icerik = ozetIcerik;
                kartlar.Kategori = ani.Kategori.KategoriAdi;
                kartlar.Resim = ilkResim;
                kartlar.Yazar = yazar;

                // Anı kartını FlowLayoutPanel'e ekler
                flp_Anilar.Controls.Add(kartlar);
            }
        }

        private void isimGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ID'sine göre bulur
            var isimSoyisim = context.Kullanicilar.Where(k => k.Id == int.Parse(_kullaniciID)).FirstOrDefault();
            // Kullanıcının ad ve soyadını etikete atar
            lbl_isim.Text = isimSoyisim.AdiSoyadi;
        }

        // Anı arama çubuğu
        private void txt_AniAra_TextChanged(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Arama metnine göre anıları filtreler
            var aniSonuc = context.Anilar.Where(a => a.Baslik.Contains(txt_AniAra.Text)).ToList();

            // FlowLayoutPanel'deki her kontrolü kontrol eder
            foreach (Control control in flp_Anilar.Controls)
            {
                if (control is AniKart ac)
                {
                    // Anı kartının başlığını alır
                    string aniBaslik = ac.Baslik;
                    // Kartın görünürlüğünü, aranan metne uygunluğuna göre ayarlar
                    ac.Visible = aniSonuc.Any(a => a.Baslik == aniBaslik);
                }
            }
        }
    }
}