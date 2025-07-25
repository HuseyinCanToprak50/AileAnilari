using AileAnilari.Model;
using AileAnilari.UserControls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AileAnilari
{
    public partial class Ailem : Form
    {
        private int kullaniciID; // Aktif kullanıcının ID'sini tutan değişken

        public Ailem()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void aileKoduOlustur_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Aile kodu oluşturma formunu oluşturur ve diyalog olarak gösterir
            AileKoduOlustur kodOlusturForm = new AileKoduOlustur(kullaniciID);
            kodOlusturForm.ShowDialog();
        }

        private void Ailem_Load(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;

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
                // Kullanıcı bir gruba aitse, FlowLayoutPanel'i boyutlandırır ve konumlandırır
                flp_Ailem.Size = new Size(1197, 589);
                flp_Ailem.Location = new Point(42, 73);
                // Grup kodu ve adını etiketlere atar
                lbl_GrupKodu.Text = kullanici.AileGrubu.GrupKodu ?? "Grup kodu yok";
                lbl_GrupAdi.Text = kullanici.AileGrubu.GrupAdi ?? "Grup adı yok";
                // GroupBox'ı gizler, çıkış butonunu gösterir
                groupBox1.Visible = false;
                btn_gruptanCik.Visible = true;
            }
            else
            {
                // Kullanıcı bir gruba ait değilse, FlowLayoutPanel'i gizler
                flp_Ailem.Visible = false;
                // GroupBox'ı gösterir, çıkış butonunu gizler
                groupBox1.Visible = true;
                btn_gruptanCik.Visible = false;
            }
            // Tüm grup üyelerini getirir
            TumUyeleriGetir();
        }

        private void aileGrubaKatil_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Girilen grup koduna göre aile grubu bilgilerini sorgular
            var aileGrubuBilgileri = context.AileGrubu.Where(a => a.GrupKodu == txt_grupKodu.Text).Select(a => new
            {
                a.AileGrubuID,
                a.GrupAdi,
                a.GrupKodu
            }).FirstOrDefault();
            if (aileGrubuBilgileri != null)
            {
                // Kullanıcıyı ID'sine göre bulur
                var kullanici = context.Kullanicilar.FirstOrDefault(k => k.Id == kullaniciID);

                if (kullanici != null)
                {
                    // Kullanıcının AileGrubuID'sini günceller
                    kullanici.AileGrubuID = aileGrubuBilgileri.AileGrubuID;
                    // Değişiklikleri veritabanına kaydeder
                    int sonuc = context.SaveChanges();
                    if (sonuc > 0)
                    {
                        // Başarılıysa mesaj gösterir ve grubu yeniler
                        MessageBox.Show("Gruba Başarıyla Katıldınız", "Aile Grubuna Katılma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GrupBilgileriniVeUyeleriYenile();
                    }
                    else
                    {
                        // Başarısızsa hata mesajı gösterir
                        MessageBox.Show("Gruba Katılma Başarısız", "Aile Grubuna Katılma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Kullanıcı bulunamazsa hata mesajı gösterir
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
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

        private void TumUyeleriGetir()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Grup koduna göre grup ID'sini bulur
            var grupId = context.AileGrubu
                    .Where(g => g.GrupKodu == lbl_GrupKodu.Text)
                    .Select(g => g.AileGrubuID)
                    .FirstOrDefault();

            // Gruba ait tüm üyeleri getirir
            var tumUyeler = context.Kullanicilar.Where(k => k.AileGrubuID == grupId).ToList();

            // Her üye için bir kart oluşturur ve FlowLayoutPanel'e ekler
            foreach (var uyeler in tumUyeler)
            {
                AileUyeleriKart uyeKart = new AileUyeleriKart();
                uyeKart.ID = uyeler.Id.ToString();
                uyeKart.Rol = uyeler.Rol;
                uyeKart.AdıSoyadi = uyeler.AdiSoyadi;
                uyeKart.Meslek = uyeler?.Meslek;
                uyeKart.Telefon = uyeler?.Telefon;
                flp_Ailem.Controls.Add(uyeKart);
            }
        }

        private void aileGruplariniListele_Click(object sender, EventArgs e)
        {
            // Aile grubu listesi formunu oluşturur ve diyalog olarak gösterir
            AileGrubuListe liste = new AileGrubuListe();
            liste.ShowDialog();
        }

        private void btn_gruptanCik_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini alır
            AktifKullaniciID();
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ID'sine göre bulur
            var kullaniciGrup = context.Kullanicilar.Where(k => k.Id == kullaniciID).FirstOrDefault();
            // Çıkış onayı için diyalog gösterir
            DialogResult cvp = MessageBox.Show("Aile Grubundan Çıkmak İstediğinize Emin Misiniz?", "Aile Grubu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cvp == DialogResult.Yes)
            {
                if (kullaniciGrup != null)
                {
                    // Kullanıcının grup ID'sini null yapar (grubu terk eder)
                    kullaniciGrup.AileGrubuID = null;
                    // Değişiklikleri veritabanına kaydeder
                    context.SaveChanges();
                    // Formu yeniden yükler
                    Ailem_Load(null, EventArgs.Empty);
                    // Grup adı ve kodu etiketlerini temizler
                    lbl_GrupAdi.Text = "";
                    lbl_GrupKodu.Text = "";
                }
            }
        }

        private void GrupBilgileriniVeUyeleriYenile()
        {
            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;
            // Kullanıcıyı ve aile grubu bilgilerini alır
            var kullanici = context.Kullanicilar
                .Include(k => k.AileGrubu)
                .FirstOrDefault(k => k.Id == kullaniciID);

            if (kullanici?.AileGrubu != null)
            {
                // FlowLayoutPanel'i boyutlandırır ve konumlandırır
                flp_Ailem.Size = new Size(1197, 589);
                flp_Ailem.Location = new Point(42, 73);
                // FlowLayoutPanel'i görünür yapar
                flp_Ailem.Visible = true;

                // Grup kodu ve adını etiketlere atar
                lbl_GrupKodu.Text = kullanici.AileGrubu.GrupKodu ?? "Grup kodu yok";
                lbl_GrupAdi.Text = kullanici.AileGrubu.GrupAdi ?? "Grup adı yok";

                // GroupBox'ı gizler, çıkış butonunu gösterir
                groupBox1.Visible = false;
                btn_gruptanCik.Visible = true;

                // Tüm grup üyelerini yeniden getirir
                TumUyeleriGetir();
            }
        }
    }
}