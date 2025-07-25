using AileAnilari.Model;

namespace AileAnilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Form bileþenlerini baþlatýr
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            // Uygulamayý tamamen kapatýr
            Application.Exit();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            // Formu görev çubuðuna küçültür
            this.WindowState = FormWindowState.Minimized;
        }

        private void link_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kayýt olma formunu oluþturur ve gösterir
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            // Mevcut formu gizler
            this.Hide();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            // Veritabaný baðlantýsýný OrtakContext sýnýfýndan alýr
            var context = OrtakContext.Baglanti;

            // Kullanýcý adý ve þifreyi formdan alýr
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            // E-posta ve þifreye göre kullanýcýyý veritabanýnda arar
            var kullanicilar = context.Kullanicilar.FirstOrDefault(k => k.Mail == kullaniciAdi && k.Sifre == sifre);

            if (kullanicilar != null)
            {
                // Kullanýcý bulunursa, AnaPanel formunu kullanýcý ID'si ile açar
                AnaPanel anasayfa = new AnaPanel(kullanicilar.Id);
                anasayfa.Show();
                // Mevcut formu gizler
                this.Hide();
            }
            else
            {
                // Kullanýcý bulunamazsa hata mesajý gösterir
                MessageBox.Show("E-Posta ya da þifre hatalý tekrar deneyiniz!", "HATALI GÝRÝÞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Þifremi unuttum formunu oluþturur ve gösterir
            SifremiUnuttum sifreUnuttum = new SifremiUnuttum();
            sifreUnuttum.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare sol tuþuna basýldýðýnda formun taþýnmasýný saðlar
            if (e.Button == MouseButtons.Left)
            {
                // Fare yakalamayý devre dýþý býrakýr
                Capture = false;
                // Windows mesajý oluþturur ve formu taþýmak için WM_NCLBUTTONDOWN mesajýný gönderir
                Message msg = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiðinde kullanýcý adý ve þifre alanlarýný varsayýlan deðerlerle doldurur
            txt_kullaniciAdi.Text = "hcan.toprak06@gmail.com";
            txt_sifre.Text = "bil123";
        }
    }
}