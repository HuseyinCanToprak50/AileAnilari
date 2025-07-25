using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AileAnilari.Model;

namespace AileAnilari
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            // Form bileşenlerini başlatır
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            // Formu kapatır
            this.Close();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            // Formu görev çubuğuna küçültür
            this.WindowState = FormWindowState.Minimized;
        }

        private void link_GirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Giriş yap formunu oluşturur ve gösterir
            Form1 girisYap = new Form1();
            girisYap.Show();
            // Mevcut formu gizler
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // Yeni bir kullanıcı nesnesi oluşturur ve formdan gelen verilerle doldurur
            Kullanicilar kullanici = new Kullanicilar
            {
                AdiSoyadi = txt_kullaniciAdi.Text,
                Rol = combo_Rol.Text,
                Mail = txt_eposta.Text,
                Sifre = txt_sifre.Text,
                KayitTarihi = DateTime.Now
            };

            // Veritabanı bağlantısını OrtakContext sınıfından alır
            var context = OrtakContext.Baglanti;

            // Yeni kullanıcıyı veritabanına ekler
            context.Kullanicilar.Add(kullanici);
            // Değişiklikleri veritabanına kaydeder ve sonucu alır
            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                // Kayıt başarılıysa mesaj gösterir ve giriş formuna yönlendirir
                MessageBox.Show("Kullanıcı Başarıyla Eklendi!", "Aile Anıları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 girisYap = new Form1();
                girisYap.Show();
                this.Hide();
            }
            else
            {
                // Kayıt başarısızsa hata mesajı gösterir
                MessageBox.Show("Kullanıcı Eklenemedi!", "Aile Anıları", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // Şifre görünür hale gelir (parola karakteri gizlemesi kalkar)
                txt_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                // Şifre gizlenir (parola karakteri gizlemesi aktif olur)
                txt_sifre.UseSystemPasswordChar = true;
            }
        }

        private void KayitOl_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare sol tuşuna basıldığında formun taşınmasını sağlar
            if (e.Button == MouseButtons.Left)
            {
                // Fare yakalamayı devre dışı bırakır
                Capture = false;
                // Windows mesajı oluşturur ve formu taşımak için WM_NCLBUTTONDOWN mesajını gönderir
                Message msg = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }
    }
}