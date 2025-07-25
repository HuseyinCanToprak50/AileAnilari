using AileAnilari.Model;
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
    public partial class AileKoduOlustur : Form
    {
        private readonly int kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public AileKoduOlustur(int aktifKullaniciID)
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
            // Parametre olarak gelen kullanıcı ID'sini sınıf değişkenine atar
            this.kullaniciID = aktifKullaniciID;
        }

        static string KodUret(int maksimumUzunluk)
        {
            // Kodda kullanılacak karakterleri tanımlar
            const string harfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789$?#";
            // Rastgele sayı üretmek için Random nesnesi oluşturur
            Random rnd = new Random();
            // 5 ile maksimumUzunluk arasında rastgele bir uzunluk belirler
            int uzunluk = rnd.Next(5, maksimumUzunluk + 1);
            // Belirlenen uzunlukta bir karakter dizisi oluşturur
            char[] karakterler = new char[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                // Her pozisyona rastgele bir karakter atar
                karakterler[i] = harfler[rnd.Next(harfler.Length)];
            }
            // Karakter dizisini string'e dönüştürüp döndürür
            return new string(karakterler);
        }

        private void btn_RastgeleKodOlustur_Click(object sender, EventArgs e)
        {
            // KodUret metodunu çağırarak 10 karakterli rastgele bir kod üretir
            string rastgeleKod = KodUret(10);
            // Üretilen kodu txt_grupKodu metin kutusuna yazar
            txt_grupKodu.Text = rastgeleKod;
        }

        private void AileKoduOlustur_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışır, şu an boş
        }

        private void btn_GrupOlustur_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Yeni bir AileGrubu nesnesi oluşturur ve özelliklerini formdan doldurur
            var AileGrubu = new AileGrubu
            {
                GrupAdi = txt_GrupAdi.Text,
                GrupKodu = txt_grupKodu.Text
            };

            // Yeni AileGrubu'nu veritabanına ekler
            context.AileGrubu.Add(AileGrubu);
            // Değişiklikleri veritabanına kaydeder ve sonucu alır
            int sonuc = context.SaveChanges();

            // Grup oluşturma sonucuna göre mesaj gösterir
            MessageBox.Show($"{(sonuc > 0 ? "Aile Grubu Başarılı Bir Şekilde Oluşturuldu" : "Aile Grubu Oluşturulamadı")}");

            // Ailem formunu oluşturur
            Ailem ailemForm = new Ailem();
            // Yeni oluşturulan grubun kodunu Ailem formundaki etikete atar
            ailemForm.lbl_GrupKodu.Text = AileGrubu.GrupKodu;

            // AnaPanel formunu oluşturur
            AnaPanel panel = new AnaPanel();

            try
            {
                // Kullanıcıyı ID'sine göre veritabanında arar
                var kullanici = context.Kullanicilar.FirstOrDefault(k => k.Id == kullaniciID);

                if (kullanici != null)
                {
                    // Kullanıcının AileGrubuID'sini yeni grubun ID'si ile günceller
                    kullanici.AileGrubuID = AileGrubu.AileGrubuID;
                    // Değişiklikleri veritabanına kaydeder
                    int veritabanıSonuc = context.SaveChanges();

                    // Atama sonucuna göre mesaj gösterir
                    MessageBox.Show(veritabanıSonuc > 0
                        ? "Grup oluşturuldu ve kullanıcıya atandı."
                        : "Grup oluşturuldu ama kullanıcıya atanamadı.");
                }
                else
                {
                    // Kullanıcı bulunamazsa hata mesajı gösterir
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }
            }
            catch (Exception ex)
            {
                // Hata oluşursa, hata mesajını kullanıcıya gösterir
                MessageBox.Show($"Bir hatayla karşılaşıldı: {ex.Message}");
            }
        }
    }
}