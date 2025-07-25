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
    public partial class UyelerProfilDetay : Form
    {
        private readonly int _uyeId; // Üyenin ID'sini tutan değişken

        public UyelerProfilDetay(int uyeId)
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
            // Parametre olarak gelen üye ID'sini sınıf değişkenine atar
            this._uyeId = uyeId;
        }

        private void UyelerProfilDetay_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde üye bilgilerini getirir
            UyeBilgileriGetir(_uyeId);
        }

        private void UyeBilgileriGetir(int ID)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Belirtilen ID'ye sahip kullanıcıları veritabanından çeker
            var kullanicilar = context.Kullanicilar.Where(k => k.Id == ID).ToList();
            // Üyenin eklediği anı sayısını hesaplar
            var Anilar = context.Anilar.Where(a => a.EkleyenKullaniciID == ID).Count();
            // Üyenin eklediği tavsiye sayısını hesaplar
            var Tavsiyeler = context.Tavsiyeler.Where(t => t.KullaniciID == ID).Count();
            // Her kullanıcı için bilgileri etiketlere atar
            foreach (var uye in kullanicilar)
            {
                lbl_ID.Text = uye.Id.ToString();
                lbl_AdiSoyadi.Text = uye.AdiSoyadi;
                lblRol.Text = uye.Rol.ToString();
                lbl_Mail.Text = uye.Mail.ToString();
                lbl_DogumTarihi.Text = uye.DogumTarihi.ToString();
                lbl_Telefon.Text = uye.Telefon;
                lbl_Adres.Text = uye.Adres;
                lbl_Meslek.Text = uye.Meslek;
                lbl_Cinsiyet.Text = uye.Cinsiyet;
                lbl_kayitTarihi.Text = uye.KayitTarihi.ToString();
            }

            // Anı ve tavsiye sayılarını etiketlere atar
            lbl_AniSayisi.Text = Anilar.ToString();
            lbl_TavsiyeSayisi.Text = Tavsiyeler.ToString();
        }
    }
}