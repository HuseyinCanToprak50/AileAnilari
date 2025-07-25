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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AileAnilari
{
    public partial class ZamanCizelgesi : Form
    {
        private int kullaniciID; // Aktif kullanıcının ID'sini tutan değişken
        private string grupKodu; // Kullanıcının ait olduğu grup kodunu tutan değişken

        public ZamanCizelgesi()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void ZamanCizelgesi_Load(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Grup kodunu alır
            GrupKodunuGetir();
            // Anıları getirir
            AnilariGetir();
        }

        private void AnilariGetir()
        {
            // Yeni bir AniKart nesnesi oluşturur (kullanılmıyor, gereksiz görünüyor)
            AniKart aniControl = new AniKart();

            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Grup koduna göre grup ID'sini bulur
            var grupID = context.AileGrubu.Where(g => g.GrupKodu == grupKodu).Select(g => g.AileGrubuID).FirstOrDefault();

            // Bu gruba ait kullanıcı ID'lerini çeker
            var kullaniciIDListesi = context.Kullanicilar.Where(k => k.AileGrubuID == grupID).Select(k => k.Id).ToList();

            // Gruba ait kullanıcılar tarafından eklenen anıları tarihe göre sıralı olarak çeker
            var anilar = context.Anilar.Where(a => kullaniciIDListesi.Contains(a.EkleyenKullaniciID)).OrderBy(a => a.Tarih).Include(kategori => kategori.Kategori).Include(medya => medya.Medyalar).ToList();
            // Resim dosyası uzantılarını tanımlar
            string[] resimUzantilari = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            // Veri tabanında KategoriID'lere karşılık gelen kategori adlarını çeker
            var kategoriAd = context.Anilar.Include(k => k.Kategori).ToList();

            // Tüm kullanıcıları veritabanından çeker
            var kullanicilar = context.Kullanicilar.ToList();

            foreach (var ani in anilar)
            {
                // İçeriği 100 karakterden uzunsa 60 karaktere kısaltır ve sonuna "...." ekler
                string ozetIcerik = ani.Icerik.Length > 100 ? ani.Icerik.Substring(0, 60) + "...." : ani.Icerik;
                // Anıyı ekleyen kullanıcının ad ve soyadını bulur
                var yazar = kullanicilar.FirstOrDefault(y => y.Id == ani.EkleyenKullaniciID)?.AdiSoyadi;

                // Anıya ait medyalar arasından ilk resim dosyasını bulur
                var ilkResim = ani.Medyalar
                 .Where(m => resimUzantilari.Contains(Path.GetExtension(m.DosyaYolu).ToLower()))
                 .FirstOrDefault()?.DosyaYolu;

                // Yeni bir anı kartı oluşturur
                AniKart kartlar = new AniKart();
                kartlar.AnıID = ani.AnıID;
                kartlar.Baslik = ani.Baslik;
                kartlar.Tarih = ani.Tarih.ToString();
                kartlar.Icerik = ani.Icerik;
                kartlar.Kategori = ani.Kategori.KategoriAdi;
                kartlar.Resim = ilkResim;
                kartlar.Yazar = yazar;
                // Anı kartını FlowLayoutPanel'e ekler
                flp_Anilar.Controls.Add(kartlar);
            }

            // Grup ID'sini ve ilgili bilgileri almak için
            AktifKullaniciID(); // Önce kullaniciID'yi al

            // Kullanıcı ve aile grubu bilgilerini sorgular
            var aileGrubu = context.Kullanicilar
                .Include(k => k.AileGrubu)
                .Where(k => k.Id == kullaniciID)
                .Select(k => new
                {
                    KullaniciID = k.Id,
                    k.AdiSoyadi,
                    AileGrubuID = k.AileGrubu,
                    GrupAdi = k.AileGrubu,
                    GrupKodu = k.AileGrubu
                })
                .ToList();

            // Kullanıcıyı ve aile grubu bilgilerini alır
            var kullanici = context.Kullanicilar
                .Include(k => k.AileGrubu)
                .FirstOrDefault(k => k.Id == kullaniciID);

            if (kullanici?.AileGrubu != null)
            {
                // Kullanıcı bir gruba aitse, grup kodunu etikete atar
                lbl_grupKodu.Text = kullanici.AileGrubu.GrupKodu;
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

        private void GrupKodunuGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ve aile grubu bilgilerini alır
            var kullanici = context.Kullanicilar.Include(k => k.AileGrubu).FirstOrDefault(k => k.Id == kullaniciID);

            if (kullanici?.AileGrubu != null)
            {
                // Kullanıcı bir gruba aitse, grup kodunu alır ve etikete atar
                grupKodu = kullanici.AileGrubu.GrupKodu;
                lbl_grupKodu.Text = grupKodu;
            }
            else
            {
                // Grup bulunamazsa, grup kodunu boşaltır ve hata mesajı gösterir
                grupKodu = "";
                lbl_grupKodu.Text = "Grup kodu bulunamadı";
            }
        }

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