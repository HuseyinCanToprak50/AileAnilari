namespace AileAnilari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_kullaniciAdi = new TextBox();
            txt_sifre = new TextBox();
            btn_Giris = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btn_kucult = new Button();
            btn_kapat = new Button();
            lbl_baslik = new Label();
            link_sifremiUnuttum = new LinkLabel();
            link_kayit = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.BackColor = SystemColors.Info;
            txt_kullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txt_kullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kullaniciAdi.Location = new Point(336, 294);
            txt_kullaniciAdi.Multiline = true;
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.PlaceholderText = "Kullanıcı Adı veya E-Posta";
            txt_kullaniciAdi.Size = new Size(325, 44);
            txt_kullaniciAdi.TabIndex = 0;
            // 
            // txt_sifre
            // 
            txt_sifre.BackColor = SystemColors.Info;
            txt_sifre.BorderStyle = BorderStyle.FixedSingle;
            txt_sifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sifre.Location = new Point(336, 353);
            txt_sifre.Multiline = true;
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '•';
            txt_sifre.PlaceholderText = "Şifre";
            txt_sifre.Size = new Size(325, 44);
            txt_sifre.TabIndex = 1;
            // 
            // btn_Giris
            // 
            btn_Giris.BackColor = Color.Transparent;
            btn_Giris.FlatAppearance.BorderSize = 2;
            btn_Giris.FlatStyle = FlatStyle.Flat;
            btn_Giris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Giris.ForeColor = SystemColors.ControlLightLight;
            btn_Giris.Location = new Point(363, 443);
            btn_Giris.Name = "btn_Giris";
            btn_Giris.Size = new Size(279, 65);
            btn_Giris.TabIndex = 2;
            btn_Giris.Text = "Giriş Yap";
            btn_Giris.UseVisualStyleBackColor = false;
            btn_Giris.Click += btn_Giris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_kucult);
            panel1.Controls.Add(btn_kapat);
            panel1.Controls.Add(lbl_baslik);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 50);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(426, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 6;
            label1.Text = "-GİRİŞ YAP-";
            // 
            // btn_kucult
            // 
            btn_kucult.BackColor = Color.Peru;
            btn_kucult.FlatStyle = FlatStyle.Flat;
            btn_kucult.ForeColor = Color.Peru;
            btn_kucult.Image = (Image)resources.GetObject("btn_kucult.Image");
            btn_kucult.Location = new Point(923, 9);
            btn_kucult.Name = "btn_kucult";
            btn_kucult.Size = new Size(35, 32);
            btn_kucult.TabIndex = 5;
            btn_kucult.UseVisualStyleBackColor = false;
            btn_kucult.Click += btn_kucult_Click;
            // 
            // btn_kapat
            // 
            btn_kapat.BackColor = Color.Peru;
            btn_kapat.FlatStyle = FlatStyle.Flat;
            btn_kapat.ForeColor = Color.Peru;
            btn_kapat.Image = (Image)resources.GetObject("btn_kapat.Image");
            btn_kapat.Location = new Point(964, 3);
            btn_kapat.Name = "btn_kapat";
            btn_kapat.Size = new Size(39, 44);
            btn_kapat.TabIndex = 4;
            btn_kapat.UseVisualStyleBackColor = false;
            btn_kapat.Click += btn_kapat_Click;
            // 
            // lbl_baslik
            // 
            lbl_baslik.AutoSize = true;
            lbl_baslik.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_baslik.ForeColor = SystemColors.Control;
            lbl_baslik.Location = new Point(12, 14);
            lbl_baslik.Name = "lbl_baslik";
            lbl_baslik.Size = new Size(133, 22);
            lbl_baslik.TabIndex = 0;
            lbl_baslik.Text = "Aile Anı Arşivi";
            // 
            // link_sifremiUnuttum
            // 
            link_sifremiUnuttum.AutoSize = true;
            link_sifremiUnuttum.BackColor = Color.Transparent;
            link_sifremiUnuttum.LinkColor = Color.FromArgb(224, 224, 224);
            link_sifremiUnuttum.Location = new Point(544, 400);
            link_sifremiUnuttum.Name = "link_sifremiUnuttum";
            link_sifremiUnuttum.Size = new Size(117, 20);
            link_sifremiUnuttum.TabIndex = 4;
            link_sifremiUnuttum.TabStop = true;
            link_sifremiUnuttum.Text = "Şifremi Unuttum";
            link_sifremiUnuttum.LinkClicked += link_sifremiUnuttum_LinkClicked;
            // 
            // link_kayit
            // 
            link_kayit.AutoSize = true;
            link_kayit.BackColor = Color.Transparent;
            link_kayit.LinkColor = Color.FromArgb(224, 224, 224);
            link_kayit.Location = new Point(440, 524);
            link_kayit.Name = "link_kayit";
            link_kayit.Size = new Size(133, 20);
            link_kayit.TabIndex = 5;
            link_kayit.TabStop = true;
            link_kayit.Text = "Yeni Hesap Oluştur";
            link_kayit.LinkClicked += link_kayit_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 673);
            Controls.Add(link_kayit);
            Controls.Add(link_sifremiUnuttum);
            Controls.Add(panel1);
            Controls.Add(btn_Giris);
            Controls.Add(txt_sifre);
            Controls.Add(txt_kullaniciAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_kullaniciAdi;
        private TextBox txt_sifre;
        private Button btn_Giris;
        private Panel panel1;
        private Button btn_kapat;
        private Label lbl_baslik;
        private Button btn_kucult;
        private LinkLabel link_sifremiUnuttum;
        private LinkLabel link_kayit;
        private Label label1;
    }
}
