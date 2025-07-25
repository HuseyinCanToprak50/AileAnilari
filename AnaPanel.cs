
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AileAnilari
{
    public partial class AnaPanel : Form
    {
        private bool isSidebarExpanded = false;
        private int kullaniciId;
        private Point lastPoint;
        public static AnaPanel Instance { get; private set; }

        public AnaPanel()
        {
            InitializeComponent();
            Instance = this; // Kendini static property'ye ata

        }
        public AnaPanel(int KullaniciID)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.kullaniciId = KullaniciID;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            //Açık olan tüm formları kapat
            CloseAllChilForms();
            Anasayfa anasayfa = new Anasayfa(lbl_kullaniciID.Text);
            anasayfa.MdiParent = this;
            anasayfa.StartPosition = FormStartPosition.Manual;
            anasayfa.Location = new Point(0, 0); // sol üst köşe
            anasayfa.Show();
        }

        private void btn_zamanCizelgesi_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            ZamanCizelgesi zamanCizelgesi = new ZamanCizelgesi();
            zamanCizelgesi.MdiParent = this;
            zamanCizelgesi.StartPosition = FormStartPosition.Manual;
            zamanCizelgesi.Location = new Point(0, 0); // sol üst köşe
            zamanCizelgesi.Show();
        }

        private void CloseAllChilForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_aniEkle_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            AniEkle anasafya = new AniEkle(lbl_kullaniciID.Text);
            anasafya.MdiParent = this;
            anasafya.StartPosition = FormStartPosition.Manual;
            anasafya.Location = new Point(0, 0);
            anasafya.Show();
        }

        private void AnaPanel_Load(object sender, EventArgs e)
        {

            lbl_kullaniciID.Text = kullaniciId.ToString();

            CloseAllChilForms();
            Profilim profil = new Profilim();
            profil.MdiParent = this;
            profil.StartPosition = FormStartPosition.Manual;
            profil.Location = new Point(0, 0);
            profil.Show();
        }

        private void btn_kategoriler_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.MdiParent = this;
            kategoriler.StartPosition = FormStartPosition.Manual;
            kategoriler.Location = new Point(0, 0);
            kategoriler.Show();
        }

        private void btn_ailem_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            Ailem ailem = new Ailem();
            ailem.MdiParent = this;
            ailem.StartPosition = FormStartPosition.Manual;
            ailem.Location = new Point(0, 0);
            ailem.Show();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            Profilim profil = new Profilim();
            profil.MdiParent = this;
            profil.StartPosition = FormStartPosition.Manual;
            profil.Location = new Point(0, 0);
            profil.Show();
        }

        private void btn_hakkinda_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            Hakkında hakkinda = new Hakkında();
            hakkinda.MdiParent = this;
            hakkinda.StartPosition = FormStartPosition.Manual;
            hakkinda.Location = new Point(0, 0);
            hakkinda.Show();
        }

        private void btn_tavsiyeler_Click(object sender, EventArgs e)
        {
            CloseAllChilForms();
            AileTavsiyeleri tavsiyeler = new AileTavsiyeleri();
            tavsiyeler.MdiParent = this;
            tavsiyeler.StartPosition = FormStartPosition.Manual;
            tavsiyeler.Location = new Point(0, 0);
            tavsiyeler.Show();
        }

        //Formu Hareket Ettirmek için
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //Fare sol tuşuna basılıp basılmadığını kontrol eder
            {
                lastPoint = e.Location;  //Fare sol tuşuna basılıp basılmadığını kontrol eder.
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location; 
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; //Formun sol kenar konumunu, farenin X eksenindeki hareketi kadar günceller.
                this.Top += e.Y - lastPoint.Y; //Formun üst kenar konumunu, farenin Y eksenindeki hareketi kadar günceller.
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }



}