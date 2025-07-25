using AileAnilari.Model;

namespace AileAnilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Form bile�enlerini ba�lat�r
            InitializeComponent();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            // Uygulamay� tamamen kapat�r
            Application.Exit();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            // Formu g�rev �ubu�una k���lt�r
            this.WindowState = FormWindowState.Minimized;
        }

        private void link_kayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kay�t olma formunu olu�turur ve g�sterir
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            // Mevcut formu gizler
            this.Hide();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            // Veritaban� ba�lant�s�n� OrtakContext s�n�f�ndan al�r
            var context = OrtakContext.Baglanti;

            // Kullan�c� ad� ve �ifreyi formdan al�r
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;

            // E-posta ve �ifreye g�re kullan�c�y� veritaban�nda arar
            var kullanicilar = context.Kullanicilar.FirstOrDefault(k => k.Mail == kullaniciAdi && k.Sifre == sifre);

            if (kullanicilar != null)
            {
                // Kullan�c� bulunursa, AnaPanel formunu kullan�c� ID'si ile a�ar
                AnaPanel anasayfa = new AnaPanel(kullanicilar.Id);
                anasayfa.Show();
                // Mevcut formu gizler
                this.Hide();
            }
            else
            {
                // Kullan�c� bulunamazsa hata mesaj� g�sterir
                MessageBox.Show("E-Posta ya da �ifre hatal� tekrar deneyiniz!", "HATALI G�R��", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // �ifremi unuttum formunu olu�turur ve g�sterir
            SifremiUnuttum sifreUnuttum = new SifremiUnuttum();
            sifreUnuttum.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Fare sol tu�una bas�ld���nda formun ta��nmas�n� sa�lar
            if (e.Button == MouseButtons.Left)
            {
                // Fare yakalamay� devre d��� b�rak�r
                Capture = false;
                // Windows mesaj� olu�turur ve formu ta��mak i�in WM_NCLBUTTONDOWN mesaj�n� g�nderir
                Message msg = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form y�klendi�inde kullan�c� ad� ve �ifre alanlar�n� varsay�lan de�erlerle doldurur
            txt_kullaniciAdi.Text = "hcan.toprak06@gmail.com";
            txt_sifre.Text = "bil123";
        }
    }
}